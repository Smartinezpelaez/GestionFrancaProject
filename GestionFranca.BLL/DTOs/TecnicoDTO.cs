
using GestionFranca.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace GestionFranca.BLL.DTOs
{
    public class TecnicoDTO
    {
        [Key]
        public int TecnicoId { get; set; } // int

        [Required]
        public string Nombre { get; set; } = null!; // varchar(50)

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "La propiedad solo puede contener letras y números")]
        public string Codigo { get; set; } = null!; // varchar(50)

        [Required]
        public decimal SueldoBase { get; set; } // decimal(10, 2)

        public int SucursalId { get; set; } // int

       

       

        public virtual ICollection<TecnicoElemento> TecnicoElementos { get; set; } = new List<TecnicoElemento>();

    }
}
