using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Domain.Abstractions.Entities;
public abstract class EntityAuditBase<T> : EntityBase<T>, IEntityAuditBase<T>
{
    public DateTime NgayTao { get; set; }
    public DateTime? NgaySua { get; set; }

    [MaxLength(30)]
    [Column(TypeName = "varchar(30)")]
    public string? NguoiTao { get; set; }

    [MaxLength(30)]
    [Column(TypeName = "varchar(30)")]
    public string? NguoiSua { get; set; }
}

public abstract class EntityAuditBase : IAuditTable
{
    public DateTime NgayTao { get; set; }
    public DateTime? NgaySua { get; set; }

    [MaxLength(30)]
    [Column(TypeName = "varchar(30)")]
    public string? NguoiTao { get; set; }

    [MaxLength(30)]
    [Column(TypeName = "varchar(30)")]
    public string? NguoiSua { get; set; }
}


