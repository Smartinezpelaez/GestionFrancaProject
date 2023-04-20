using System;
using System.Collections.Generic;

namespace GestionFranca.DAL.Models;

public partial class Elemento
{
    public int ElementoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<TecnicoElemento> TecnicoElementos { get; set; } = new List<TecnicoElemento>();
}
