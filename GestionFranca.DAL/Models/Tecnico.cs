using System;
using System.Collections.Generic;

namespace GestionFranca.DAL.Models;

public partial class Tecnico
{
    public int TecnicoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public decimal SueldoBase { get; set; }

    public int SucursalId { get; set; }

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual ICollection<TecnicoElemento> TecnicoElementos { get; set; } = new List<TecnicoElemento>();
}
