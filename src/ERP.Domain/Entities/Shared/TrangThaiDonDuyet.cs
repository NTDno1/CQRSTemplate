using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Shared;


public sealed class TrangThaiDonDuyet : SmartEnum<TrangThaiDonDuyet, string>
{
    public static readonly TrangThaiDonDuyet ChuaDuyet = new TrangThaiDonDuyet(nameof(ChuaDuyet), "Chưa duyệt");
    public static readonly TrangThaiDonDuyet DaDuyet = new TrangThaiDonDuyet(nameof(DaDuyet), "Đã duyệt");
    public static readonly TrangThaiDonDuyet HuyDuyet = new TrangThaiDonDuyet(nameof(HuyDuyet), "Hủy duyệt");

    private TrangThaiDonDuyet(string name, string value) : base(name, value) { }
}
