namespace ERP.Domain.Entities.WareHouses.ChuyenKho;

public sealed class NhatHang
{
    public decimal SoLuongDaNhat { get; init; }

    public string? NguoiNhatHang { get; init; }

    public DateTime? NgayNhatHang { get; init; }

    public static NhatHang Create(decimal soLuongDaNhat, string? nguoiNhatHang, DateTime? ngayNhatHang)
    {
        return new NhatHang
        {
            SoLuongDaNhat = soLuongDaNhat,
            NguoiNhatHang = nguoiNhatHang,
            NgayNhatHang = ngayNhatHang
        };
    }

}
