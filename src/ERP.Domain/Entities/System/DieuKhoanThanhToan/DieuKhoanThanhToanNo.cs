namespace ERP.Domain.Entities.System.DieuKhoanThanhToan;


public sealed record DieuKhoanThanhToanNo
{
    private DieuKhoanThanhToanNo()
    {
    }

    public int SoThangDuocNo { get; init; }
    public int SoNgayDuocNo { get; init; }
    public int NgayThanhToan { get; init; }
    public DateTime? TuNgay { get; init; }

    public DateTime? DenNgay { get; init; }

    public static DieuKhoanThanhToanNo Create(int soThangDuocNo, int soNgayDuocNo, int ngayThanhToan, DateTime? tuNgay, DateTime? denNgay)
    {
        if (tuNgay > denNgay)
        {
            throw new ApplicationException("Đến ngày phải chọn ngày sau từ ngày!");
        }

        return new DieuKhoanThanhToanNo
        {
            SoThangDuocNo = soThangDuocNo,
            SoNgayDuocNo = soNgayDuocNo,
            NgayThanhToan = ngayThanhToan,
            TuNgay = tuNgay,
            DenNgay = denNgay
        };
    }

}
