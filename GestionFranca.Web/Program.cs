
using GestionFranca.BLL.Repository;
using GestionFranca.BLL.Repository.Implements;
using GestionFranca.BLL.Services;
using GestionFranca.DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GestionFrancaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GestionFrancaContext")));
builder.Services.AddControllersWithViews();


//builder.Services.AddSingleton<SucursalService>();

// Add AutoMapper Injection
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Repository
builder.Services.AddScoped<ITecnicoRepository, TecnicoRepository>();
builder.Services.AddScoped<ISucursalRepository, SucursalRepository>();
builder.Services.AddScoped<IElementoRepository, ElementoRepository>();

// Implements The Singleton Patern
builder.Services.AddRazorPages();
//builder.Services.AddSingleton<TecnicoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
