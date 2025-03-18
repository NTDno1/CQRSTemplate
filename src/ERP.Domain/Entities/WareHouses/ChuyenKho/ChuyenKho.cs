using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.WareHouses.ChuyenKho;

public sealed class ChuyenKho : AggregateRoot
{
    private readonly List<ChuyenKhoChiTiet> _chuyenKhoChiTiets;

    private ChuyenKho()
    {
        _chuyenKhoChiTiets = [];
    }

    public ChuyenKho(
    string maChuyenKho,
    string? dienGiai,
    string? trucThuoc,
    string? soBill,
    string? hinhThucChuyen,
    Ulid? idKhoXuatHang,
    Ulid? idKhoNhanHang,
    DateTime? ngayXacNhanXuat,
    string? nguoiXacNhanXuat,
    string? nguoiNhanHang,
    DateTime? thoiGianNhanHang,
    string? soHoaDon)
    {
        Id = Ulid.NewUlid();
        MaChuyenKho = maChuyenKho;
        NgayChungTu = DateOnly.FromDateTime(DateTime.Now);
        DienGiai = dienGiai;
        TrucThuoc = trucThuoc;
        HinhThucChuyen = hinhThucChuyen;
        SoBill = soBill;
        IdKhoNhanHang = idKhoNhanHang;
        IdKhoXuatHang = idKhoXuatHang;
        NgayXacNhanXuat = ngayXacNhanXuat;
        NguoiXacNhanXuat = nguoiXacNhanXuat;
        NguoiNhanHang = nguoiNhanHang;
        ThoiGianNhanHang = thoiGianNhanHang;
        CanXuatHoaDon = false;
        SoHoaDon = soHoaDon;
        _chuyenKhoChiTiets = new List<ChuyenKhoChiTiet>();
    }

    public string MaChuyenKho { get; private set; }

    public DateOnly NgayChungTu { get; private set; }

    public string? DienGiai { get; private set; }

    public string? TrucThuoc { get; private set; }

    public string? HinhThucChuyen { get; private set; }

    public string? TrangThai { get; private set; }

    public string? SoBill { get; private set; }

    public Ulid? IdKhoXuatHang { get; set; }

    public Ulid? IdKhoNhanHang { get; set; }

    public DateTime? NgayXacNhanXuat { get; private set; }

    public string? NguoiXacNhanXuat { get; private set; }

    public string? NguoiNhanHang { get; private set; }

    public DateTime? ThoiGianNhanHang { get; private set; }

    public bool CanXuatHoaDon { get; private set; }

    public string? SoHoaDon { get; private set; }


    public IReadOnlyCollection<ChuyenKhoChiTiet> ChuyenKhoChiTiets => _chuyenKhoChiTiets.AsReadOnly();


    public static ChuyenKho Create(
    string maChuyenKho,
    string? dienGiai,
    string? trucThuoc,
    string? soBill,
    string? hinhThucChuyen,
    Ulid? idKhoXuatHang,
    Ulid? idKhoNhanHang,
    DateTime? ngayXacNhanXuat,
    string? nguoiXacNhanXuat,
    string? nguoiNhanHang,
    DateTime? thoiGianNhanHang,
    string? soHoaDon)
    {
        return new ChuyenKho(
             maChuyenKho,
             dienGiai,
             trucThuoc,
             soBill,
             hinhThucChuyen,
             idKhoXuatHang,
             idKhoNhanHang,
             ngayXacNhanXuat,
             nguoiXacNhanXuat,
             nguoiNhanHang,
             thoiGianNhanHang,
             soHoaDon
        );
    }

    public void Update(
    string? dienGiai,
    string? trucThuoc,
    string? soBill,
    string? hinhThucChuyen,
    Ulid? idKhoXuatHang,
    Ulid? idKhoNhanHang,
    DateTime? ngayXacNhanXuat,
    string? nguoiXacNhanXuat,
    string? nguoiNhanHang,
    DateTime? thoiGianNhanHang,
    bool? canXuatHoaDon,
    string? soHoaDon)
    {
        DienGiai = !string.IsNullOrEmpty(dienGiai) ? dienGiai : DienGiai;
        TrucThuoc = !string.IsNullOrEmpty(trucThuoc) ? trucThuoc : TrucThuoc;
        SoBill = !string.IsNullOrEmpty(soBill) ? soBill : SoBill;
        HinhThucChuyen = !string.IsNullOrEmpty(hinhThucChuyen) ? hinhThucChuyen : HinhThucChuyen;
        IdKhoXuatHang = idKhoXuatHang ?? IdKhoXuatHang;
        IdKhoNhanHang = idKhoNhanHang ?? IdKhoNhanHang;
        NgayXacNhanXuat = ngayXacNhanXuat ?? NgayXacNhanXuat;
        NguoiXacNhanXuat = !string.IsNullOrEmpty(nguoiXacNhanXuat) ? nguoiXacNhanXuat : NguoiXacNhanXuat;
        NguoiNhanHang = !string.IsNullOrEmpty(nguoiNhanHang) ? nguoiNhanHang : NguoiNhanHang;
        ThoiGianNhanHang = thoiGianNhanHang ?? ThoiGianNhanHang;
        CanXuatHoaDon = canXuatHoaDon ?? false;
        SoHoaDon = !string.IsNullOrEmpty(soHoaDon) ? soHoaDon : SoHoaDon;
    }

    public void AddChuyenKhoChiTiet(List<ChuyenKhoChiTiet> whChuyenKhoChiTiets)
    {
        _chuyenKhoChiTiets.AddRange(whChuyenKhoChiTiets);
    }


    public void UpdateDetails(List<ChuyenKhoChiTiet> updatedDetails)
    {
        var missingIds = _chuyenKhoChiTiets.Where(ct => !updatedDetails.Any(ud => ud.Id == ct.Id)).Select(ct => ct.Id).ToList();
        foreach (Ulid id in missingIds)
        {
            ChuyenKhoChiTiet? chitiet = _chuyenKhoChiTiets.FirstOrDefault(u => u.Id == id);
            if (chitiet != null)
            {
                _chuyenKhoChiTiets.Remove(chitiet);
            }
        }

        foreach (ChuyenKhoChiTiet updatedDetail in updatedDetails)
        {
            ChuyenKhoChiTiet? existingDetail = _chuyenKhoChiTiets.FirstOrDefault(d => d.Id == updatedDetail.Id);
            if (existingDetail != null)
            {
                existingDetail.Update(updatedDetail.IdHangHoa, updatedDetail.MaDieuChinh, updatedDetail.IdXuatTaiKho, updatedDetail.IdNhapTaiKho, updatedDetail.SoLuong, "561", "157", updatedDetail.DonGia, updatedDetail.ThanhTien, updatedDetail.NhatHang);
            }
            else
            {
                _chuyenKhoChiTiets.Add(updatedDetail);
            }
        }
    }

    public void RemoveChuyenKhoChiTiet(Ulid id)
    {
        var detail = _chuyenKhoChiTiets.SingleOrDefault(d => d.Id == id);
        if (detail != null)
        {
            _chuyenKhoChiTiets.Remove(detail);
        }
    }
}
