using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.KhachHang.PhanHoiKhachHang;

public sealed class PhanHoiKhachHang : AggregateRoot
{
    private PhanHoiKhachHang()
    {

    }

    public PhanHoiKhachHang(DateTime ngayPhanHoi, string idUserPhanHoi, string noiDungPhanHoi, Ulid idKhachHang, LoaiPhanHoi loaiPhanHoi, bool coGiaTri)
    {
        Id = Ulid.NewUlid();
        NgayPhanHoi = ngayPhanHoi;
        IdUserPhanHoi = idUserPhanHoi;
        NoiDungPhanHoi = noiDungPhanHoi;
        IdKhachHang = idKhachHang;
        LoaiPhanHoi = loaiPhanHoi;
        CoGiaTri = coGiaTri;
    }

    public DateTime NgayPhanHoi { get; private set; }
    public string IdUserPhanHoi { get; private set; }
    public string NoiDungPhanHoi { get; private set; }
    public Ulid IdKhachHang { get; private set; }
    public LoaiPhanHoi LoaiPhanHoi { get; private set; }
    public bool CoGiaTri { get; private set; }
    public KhachHang KhachHang { get; private set; }

    // Create method
    public static PhanHoiKhachHang Create(DateTime ngayPhanHoi, string idUserPhanHoi, string noiDungPhanHoi, Ulid idKhachHang, string loaiPhanHoi, bool coGiaTri)
    {
        LoaiPhanHoi loaiPhanHoiToAdd = LoaiPhanHoi.FromValue(loaiPhanHoi);
        return new PhanHoiKhachHang(ngayPhanHoi, idUserPhanHoi, noiDungPhanHoi, idKhachHang, loaiPhanHoiToAdd, coGiaTri);
    }

    // Update method
    public void Update(DateTime? ngayPhanHoi = null, string? idUserPhanHoi = null, string? noiDungPhanHoi = null, Ulid? idKhachHang = null, string? loaiPhanHoi = null, bool? coGiaTri = null)
    {
        LoaiPhanHoi loaiPhanHoiToUpdate = loaiPhanHoi == null ? LoaiPhanHoi : LoaiPhanHoi.FromValue(loaiPhanHoi);
        NgayPhanHoi = ngayPhanHoi ?? NgayPhanHoi;
        IdUserPhanHoi = !string.IsNullOrEmpty(idUserPhanHoi) ? idUserPhanHoi : IdUserPhanHoi;
        NoiDungPhanHoi = !string.IsNullOrEmpty(noiDungPhanHoi) ? noiDungPhanHoi : NoiDungPhanHoi;
        IdKhachHang = idKhachHang ?? IdKhachHang;
        LoaiPhanHoi = loaiPhanHoiToUpdate;
        CoGiaTri = coGiaTri ?? CoGiaTri;
    }
}
