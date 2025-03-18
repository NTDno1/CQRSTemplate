using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang.PhanHoiKhachHang;


public class LoaiPhanHoi : SmartEnum<LoaiPhanHoi, string>
{
    public static readonly LoaiPhanHoi PhanHoi = new LoaiPhanHoi(nameof(PhanHoi), "Phản hồi");
    public static readonly LoaiPhanHoi CommentBaoGia = new LoaiPhanHoi(nameof(CommentBaoGia), "Comment báo giá");
    public static readonly LoaiPhanHoi Visit = new LoaiPhanHoi(nameof(Visit), "Visit");
    public static readonly LoaiPhanHoi Tele = new LoaiPhanHoi(nameof(Tele), "Tele");
    public static readonly LoaiPhanHoi Khac = new LoaiPhanHoi(nameof(Khac), "Khác");

    private LoaiPhanHoi(string name, string value) : base(name, value) { }
}


