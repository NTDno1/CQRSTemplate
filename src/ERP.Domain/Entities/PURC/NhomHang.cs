using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.PURC;
public sealed class NhomHang : AggregateRoot, ISoftDelete
{
    private readonly List<HangHoa.HangHoa> _hangHoas;
    private NhomHang()
    {
        _hangHoas = [];
    }

    public NhomHang(string maNhomHang, Ulid? idNhomHangCha, PhanLoaiNhom phanLoaiNhom, string? ghiChu, string muaHangPhuTrach, string muaHangPhuTrachNuocNgoai, string leader, string sub, List<HangHoa.HangHoa> hangHoas)
    {
        Id = Ulid.NewUlid();
        MaNhomHang = maNhomHang;
        IdNhomHangCha = idNhomHangCha;
        PhanLoaiNhom = phanLoaiNhom;
        GhiChu = ghiChu;
        MuaHangPhuTrach = muaHangPhuTrach;
        MuaHangPhuTrachNuocNgoai = muaHangPhuTrachNuocNgoai;
        Leader = leader;
        Sub = sub;
        _hangHoas = hangHoas;
    }

    public string? MaNhomHang { get; set; }

    public Ulid? IdNhomHangCha { get; set; }
    public PhanLoaiNhom PhanLoaiNhom { get; private set; }
    public string? GhiChu { get; set; }
    public string MuaHangPhuTrach { get; set; }
    public string MuaHangPhuTrachNuocNgoai { get; set; }
    public string Leader { get; set; }

    public string Sub { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public NhomHang? NhomHangCha { get; private set; }
    public IReadOnlyCollection<HangHoa.HangHoa> HangHoas => _hangHoas.AsReadOnly();

    public static NhomHang Create(string maNhomHang, Ulid? idNhomHangCha, string phanLoaiNhom, string? ghiChu, string muaHangPhuTrach, string muaHangPhuTrachNuocNgoai, string leader, string sub, List<HangHoa.HangHoa> hangHoas)
    {
        var phanLoaiNhomEnum = PhanLoaiNhom.FromValue(phanLoaiNhom);
        var nhomHang = new NhomHang(maNhomHang, idNhomHangCha, phanLoaiNhomEnum, ghiChu, muaHangPhuTrach, muaHangPhuTrachNuocNgoai, leader, sub, hangHoas);
        return nhomHang;
    }
}
