
using GestionFranca.DAL.Models;

namespace GestionFranca.BLL.DTOs
{
    public class ElementoDTO
    {

        public int ElementoId { get; set; } // int
        public string Codigo { get; set; } = null!; // varchar(50)
        public string Nombre { get; set; } = null!; // varchar(50)

        public virtual ICollection<TecnicoElemento> TecnicoElementos { get; set; } = new List<TecnicoElemento>();


    }
}
