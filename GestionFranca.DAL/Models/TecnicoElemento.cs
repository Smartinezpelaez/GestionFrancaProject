using System;
using System.Collections.Generic;

namespace GestionFranca.DAL.Models;

public partial class TecnicoElemento
{
    public int TecnicoElementoId { get; set; }

    public int TecnicoId { get; set; }

    public int ElementoId { get; set; }

    public int Cantidad { get; set; }

    public virtual Elemento Elemento { get; set; } = null!;

    public virtual Tecnico Tecnico { get; set; } = null!;
}
