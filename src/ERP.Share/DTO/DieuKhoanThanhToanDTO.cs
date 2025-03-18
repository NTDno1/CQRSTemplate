namespace ERP.Share.DTO;
public class AddDieuKhoanThanhToanDTO
{
    public string ThoiHanThanhToan { get; set; }

    public string LoaiDieuKhoanThanhToan { get; set; }

    public DieuKhoanThanhToanDTO DieuKhoanThanhToanNo1 { get; set; }

    public DieuKhoanThanhToanDTO DieuKhoanThanhToanNo2 { get; set; }

    public DieuKhoanThanhToanDTO DieuKhoanThanhToanNo3 { get; set; }

    public decimal PhanTramThanhToan { get; set; }

    public bool IsActiveAuto { get; set; }

    public bool IsActiveGiga { get; set; }
}

public class DieuKhoanThanhToanDTO
{
    public int SoThangDuocNo { get; init; }
    public int SoNgayDuocNo { get; init; }
    public int NgayThanhToan { get; init; }
    public string? TuNgay { get; init; }

    public string? DenNgay { get; init; }
}
