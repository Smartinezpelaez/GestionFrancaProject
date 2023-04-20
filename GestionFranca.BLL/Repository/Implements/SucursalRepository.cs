using GestionFranca.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFranca.BLL.Repository.Implements
{
    public class SucursalRepository : GenericRepository<Sucursal>, ISucursalRepository
    {
        private readonly GestionFrancaContext context;

        public SucursalRepository(GestionFrancaContext context): base(context)
        {
            this.context = context;
        }

        public new async Task DeleteAsync(int id)
        {
            var sucursal = await GetByIdAsync(id);

            if (sucursal == null) throw new Exception("The entity is null.");
            //if (context.Autores.Any(x => x.Id == id)) throw new Exception("Foreign Key Accounts.");

            context.Sucursals.Remove(sucursal);
            await context.SaveChangesAsync();

        }
    }
}
