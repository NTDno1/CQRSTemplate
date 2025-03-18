namespace ERP.Domain.Entities.Shared;


public sealed record TaiKhoanNganHang
{

    public string SoTaiKhoan { get; init; }
    public string NganHang { get; init; }
    public string ChiNhanhNganHang { get; init; }
    public string NguoiThuHuong { get; init; }


    public static TaiKhoanNganHang Create(string soTaiKhoan, string nganHang, string chiNhanhNganHang, string nguoiThuHuong)
    {

        return new TaiKhoanNganHang
        {
            SoTaiKhoan = soTaiKhoan,
            NganHang = nganHang,
            ChiNhanhNganHang = chiNhanhNganHang,
            NguoiThuHuong = nguoiThuHuong
        };
    }

}
