using GestionFranca.DAL.Models;


namespace GestionFranca.BLL.Services
{
    public class SucursalService
    {
        //readonly ISucursalRepository sucursalRepository;
        //public SucursalService(ISucursalRepository sucursalRepository)
        //{
        //    this.sucursalRepository = sucursalRepository;
        //}
        public List<int> GetSucursalSelectList()
        {
            //List<Sucursal> resultado = new();
            // Obtener la lista de sucursales del repositorio
           // var sucursales = sucursalRepository.GetAllAsync().Result;

            //var sucursalIds = where s in Select(s => s.SucursalId).ToList();
             GestionFrancaContext context = new GestionFrancaContext();
                    var q =                 
                        from t in context.Sucursals                        
                        where t.SucursalId != 0
                        select t.SucursalId;
            //join s in context.Tecnicos on t.SucursalId equals s.SucursalId

            var resultado = q.ToList();
            // Crear un SelectList con los valores de SucursalId y la descripción que deseas mostrar
            //var sucursalSelectList = new SelectList(sucursales, "SucursalId", "Descripcion");

            return resultado;
        }
    }
}
