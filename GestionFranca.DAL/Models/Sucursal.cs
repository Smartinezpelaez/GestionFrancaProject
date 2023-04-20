using System;
using System.Collections.Generic;

namespace GestionFranca.DAL.Models;

public partial class Sucursal
{
    public int SucursalId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Tecnico> Tecnicos { get; set; } = new List<Tecnico>();
}
