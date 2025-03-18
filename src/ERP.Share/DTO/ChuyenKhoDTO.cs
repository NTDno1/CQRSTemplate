namespace ERP.Share.DTO;
public class AddChuyenKhoChiTietDTO
{
    public Ulid IdHangHoa { get; set; }

    public string? MaDieuChinh { get; set; }

    public Ulid? IdXuatTaiKho { get; set; }

    public Ulid? IdNhapTaiKho { get; set; }

    public decimal SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal ThanhTien { get; set; }

    public decimal SoLuongDaNhat { get; set; }

    public string? NguoiNhatHang { get; set; }

    public string NgayNhatHang { get; set; }
}

public class UpdateChuyenKhoChiTietDTO
{
    public Ulid Id { get; set; }

    public Ulid IdHangHoa { get; set; }

    public string? MaDieuChinh { get; set; }

    public Ulid? IdXuatTaiKho { get; set; }

    public Ulid? IdNhapTaiKho { get; set; }

    public decimal SoLuong { get; set; }

    public string TkNo { get; set; } = null!;

    public string TkCo { get; set; } = null!;

    public decimal DonGia { get; set; }

    public decimal ThanhTien { get; set; }

    public decimal SoLuongDaNhat { get; set; }

    public string? NguoiNhatHang { get; set; }

    public string? NgayNhatHang { get; set; }
}
