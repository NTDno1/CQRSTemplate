using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.BaoGias.BaoGia;
public class TrangThaiDon : SmartEnum<TrangThaiDon, string>
{
    public static readonly TrangThaiDon DaTrung = new TrangThaiDon(nameof(DaTrung), "Đã trúng");
    public static readonly TrangThaiDon DaTruot = new TrangThaiDon(nameof(DaTruot), "Đã trượt");
    public static readonly TrangThaiDon ChuaCoThongTin = new TrangThaiDon(nameof(ChuaCoThongTin), "Chưa có thông tin");

    private TrangThaiDon(string name, string value) : base(name, value) { }
}


public class TrangThaiDuyet : SmartEnum<TrangThaiDuyet, string>
{
    public static readonly TrangThaiDuyet DaDuyet = new TrangThaiDuyet(nameof(DaDuyet), "Đã duyệt");
    public static readonly TrangThaiDuyet ChoDuyet = new TrangThaiDuyet(nameof(ChoDuyet), "Chờ duyệt");
    public static readonly TrangThaiDuyet DaHuy = new TrangThaiDuyet(nameof(DaHuy), "Đã hủy");

    private TrangThaiDuyet(string name, string value) : base(name, value) { }
}


public class TrangThaiDuyetGia : SmartEnum<TrangThaiDuyetGia, string>
{
    public static readonly TrangThaiDuyetGia KhongCanDuyet = new TrangThaiDuyetGia(nameof(KhongCanDuyet), "Không cần duyệt");
    public static readonly TrangThaiDuyetGia ChoDuyet = new TrangThaiDuyetGia(nameof(ChoDuyet), "Chờ duyệt");
    public static readonly TrangThaiDuyetGia DaDuyet = new TrangThaiDuyetGia(nameof(DaDuyet), "Đã duyệt");

    private TrangThaiDuyetGia(string name, string value) : base(name, value) { }
}

