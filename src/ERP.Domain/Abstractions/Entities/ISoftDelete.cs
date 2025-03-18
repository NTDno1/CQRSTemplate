namespace ERP.Domain.Abstractions.Entities;
public interface ISoftDelete
{
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

}
