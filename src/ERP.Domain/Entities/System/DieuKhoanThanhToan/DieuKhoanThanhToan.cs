using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.System.DieuKhoanThanhToan;

public sealed class DieuKhoanThanhToan : AggregateRoot, ISoftDelete
{
    private DieuKhoanThanhToan()
    {

    }

    public DieuKhoanThanhToan(
        string thoiHanThanhToan,
        string loaiDieuKhoanThanhToan,
        DieuKhoanThanhToanNo dieuKhoanThanhToanNo1,
        DieuKhoanThanhToanNo dieuKhoanThanhToanNo2,
        DieuKhoanThanhToanNo dieuKhoanThanhToanNo3,
        decimal phanTramThanhToan,
        bool isActiveAuto,
        bool isActiveGiga)
    {
        Id = Ulid.NewUlid();
        ThoiHanThanhToan = thoiHanThanhToan;
        LoaiDieuKhoanThanhToan = loaiDieuKhoanThanhToan;
        DieuKhoanThanhToanNo1 = dieuKhoanThanhToanNo1;
        DieuKhoanThanhToanNo2 = dieuKhoanThanhToanNo2;
        DieuKhoanThanhToanNo3 = dieuKhoanThanhToanNo3;
        PhanTramThanhToan = phanTramThanhToan;
        IsActiveAuto = isActiveAuto;
        IsActiveGiga = isActiveGiga;
    }

    public string ThoiHanThanhToan { get; set; }

    public string LoaiDieuKhoanThanhToan { get; set; }

    public DieuKhoanThanhToanNo DieuKhoanThanhToanNo1 { get; set; }

    public DieuKhoanThanhToanNo DieuKhoanThanhToanNo2 { get; set; }

    public DieuKhoanThanhToanNo DieuKhoanThanhToanNo3 { get; set; }

    public decimal PhanTramThanhToan { get; set; }

    public bool IsActiveAuto { get; set; }

    public bool IsActiveGiga { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public static DieuKhoanThanhToan Create(
        string thoiHanThanhToan,
        string loaiDieuKhoanThanhToan,
        DieuKhoanThanhToanNo dieuKhoanThanhToanNo1,
        DieuKhoanThanhToanNo dieuKhoanThanhToanNo2,
        DieuKhoanThanhToanNo dieuKhoanThanhToanNo3,
        decimal phanTramThanhToan,
        bool isActiveAuto,
        bool isActiveGiga)
    {
        var dieuKhoanThanhToan = new DieuKhoanThanhToan(
            thoiHanThanhToan,
            loaiDieuKhoanThanhToan,
            dieuKhoanThanhToanNo1,
            dieuKhoanThanhToanNo2,
            dieuKhoanThanhToanNo3,
            phanTramThanhToan,
            isActiveAuto,
            isActiveGiga);

        return dieuKhoanThanhToan;
    }

    public void Update(
    string thoiHanThanhToan,
    string loaiDieuKhoanThanhToan,
    DieuKhoanThanhToanNo dieuKhoanThanhToanNo1,
    DieuKhoanThanhToanNo dieuKhoanThanhToanNo2,
    DieuKhoanThanhToanNo dieuKhoanThanhToanNo3,
    decimal phanTramThanhToan,
    bool isActiveAuto,
    bool isActiveGiga)
    {
        ThoiHanThanhToan = thoiHanThanhToan;
        LoaiDieuKhoanThanhToan = loaiDieuKhoanThanhToan;
        DieuKhoanThanhToanNo1 = dieuKhoanThanhToanNo1;
        DieuKhoanThanhToanNo2 = dieuKhoanThanhToanNo2;
        DieuKhoanThanhToanNo3 = dieuKhoanThanhToanNo3;
        PhanTramThanhToan = phanTramThanhToan;
        IsActiveAuto = isActiveAuto;
        IsActiveGiga = isActiveGiga;
    }
}
