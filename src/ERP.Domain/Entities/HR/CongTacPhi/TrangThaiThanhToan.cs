using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.HR.CongTacPhi;

public sealed class TrangThaiThanhToan : SmartEnum<TrangThaiThanhToan, string>
{
    public static readonly TrangThaiThanhToan DaThanhToan = new TrangThaiThanhToan(nameof(DaThanhToan), "Đã thanh toán");
    public static readonly TrangThaiThanhToan ChuaThanhToan = new TrangThaiThanhToan(nameof(ChuaThanhToan), "Chưa thanh toán");

    private TrangThaiThanhToan(string name, string value) : base(name, value) { }
}
