namespace ERP.Domain.Abstractions.Entities;
public interface IDateTracking
{
    DateTime NgayTao { get; set; }

    DateTime? NgaySua { get; set; }
}
