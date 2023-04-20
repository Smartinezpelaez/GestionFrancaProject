
using GestionFranca.DAL.Models;

namespace GestionFranca.BLL.DTOs
{
    public class SucursalDTO
    {

        public int SucursalId { get; set; } // int
        public string Codigo { get; set; } = null!; // varchar(50)
        public string Nombre { get; set; } = null!; // varchar(50)
        public virtual ICollection<Tecnico> Tecnicos { get; set; } = new List<Tecnico>();


    }
}
