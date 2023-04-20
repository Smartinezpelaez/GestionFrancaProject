

using GestionFranca.DAL.Models;

namespace GestionFranca.BLL.DTOs
{
    public class TecnicoElementoDTO
    {

        public int TecnicoElementoId { get; set; } // int
        public int TecnicoId { get; set; } // int
        public int ElementoId { get; set; } // int
        public int Cantidad { get; set; } // int

        public virtual Elemento Elemento { get; set; } = null!;

        public virtual Tecnico Tecnico { get; set; } = null!;
    }
}
