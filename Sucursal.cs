// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace DataModel
{
	[Table("Sucursal", Schema = "dbo")]
	public class Sucursal
	{
		[Column("SucursalId", IsPrimaryKey = true , IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public int    SucursalId { get; set; } // int
		[Column("Codigo"    , CanBeNull    = false                                                             )] public string Codigo     { get; set; } = null!; // varchar(50)
		[Column("Nombre"    , CanBeNull    = false                                                             )] public string Nombre     { get; set; } = null!; // varchar(50)

		#region Associations
		/// <summary>
		/// FK_Tecnico_Sucursal backreference
		/// </summary>
		[Association(ThisKey = nameof(SucursalId), OtherKey = nameof(Tecnico.SucursalId))]
		public IEnumerable<Tecnico> Tecnicos { get; set; } = null!;
		#endregion
	}
}
