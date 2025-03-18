using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.HR.NhanVien;

public sealed class NhanVien : AggregateRoot, ISoftDelete
{

    private NhanVien()
    {

    }

    public NhanVien(string hoVaTen, string username, string soDienThoaiCongTy, string emailCongTy, string maChamCong, string maChiNhanh, string maPhongBan, string maVanPhong, DateOnly? ngayVaoCongTy, DateOnly? ngayThuViec, DateOnly? ngayLamChinhThuc, DateOnly? ngayNghiViec, string viTri, string viTriChiTiet, string ghiChu, string maKhachHangNoiBo, bool isTraining)
    {
        Id = Ulid.NewUlid();
        HoVaTen = hoVaTen;
        Username = username;
        SoDienThoaiCongTy = soDienThoaiCongTy;
        EmailCongTy = emailCongTy;
        MaChamCong = maChamCong;
        MaChiNhanh = maChiNhanh;
        MaPhongBan = maPhongBan;
        MaVanPhong = maVanPhong;
        NgayVaoCongTy = ngayVaoCongTy;
        NgayThuViec = ngayThuViec;
        NgayLamChinhThuc = ngayLamChinhThuc;
        NgayNghiViec = ngayNghiViec;
        ViTri = viTri;
        ViTriChiTiet = viTriChiTiet;
        GhiChu = ghiChu;
        MaKhachHangNoiBo = maKhachHangNoiBo;
        IsTraining = isTraining;
    }

    public string HoVaTen { get; private set; }
    public string Username { get; private set; }
    public string SoDienThoaiCongTy { get; private set; }
    public string EmailCongTy { get; private set; }
    public string MaChamCong { get; private set; }
    public string MaChiNhanh { get; private set; }
    public string MaPhongBan { get; private set; }
    public string MaVanPhong { get; private set; }
    public DateOnly? NgayVaoCongTy { get; private set; }
    public DateOnly? NgayThuViec { get; private set; }
    public DateOnly? NgayLamChinhThuc { get; private set; }
    public DateOnly? NgayNghiViec { get; private set; }
    public string ViTri { get; private set; }
    public string ViTriChiTiet { get; private set; }
    public string GhiChu { get; private set; }
    public string MaKhachHangNoiBo { get; private set; }
    public bool IsTraining { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }
}
