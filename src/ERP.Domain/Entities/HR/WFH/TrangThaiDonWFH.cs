using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.HR.WFH;

public sealed class TrangThaiDuyet : SmartEnum<TrangThaiDuyet, string>
{
    public static readonly TrangThaiDuyet CanDuyet = new TrangThaiDuyet(nameof(CanDuyet), "Cần duyệt");
    public static readonly TrangThaiDuyet DaDuyet = new TrangThaiDuyet(nameof(DaDuyet), "Đã duyệt");
    public static readonly TrangThaiDuyet HuyDuyet = new TrangThaiDuyet(nameof(HuyDuyet), "Hủy duyệt");

    private TrangThaiDuyet(string name, string value) : base(name, value) { }
}

public sealed class TrangThaiXuLy : SmartEnum<TrangThaiXuLy, string>
{
    public static readonly TrangThaiXuLy DaHoanThanh = new TrangThaiXuLy(nameof(DaHoanThanh), "Đã hoàn thành");
    public static readonly TrangThaiXuLy ChuaXuLy = new TrangThaiXuLy(nameof(ChuaXuLy), "Chưa xử lý");
    public static readonly TrangThaiXuLy HuyXuLy = new TrangThaiXuLy(nameof(HuyXuLy), "Hủy xử lý");

    private TrangThaiXuLy(string name, string value) : base(name, value) { }
}

public sealed class TrangThaiTheoDoi : SmartEnum<TrangThaiTheoDoi, string>
{
    public static readonly TrangThaiTheoDoi DangTheoDoi = new TrangThaiTheoDoi(nameof(DangTheoDoi), "Đang theo dõi");
    public static readonly TrangThaiTheoDoi KhongTheoDoi = new TrangThaiTheoDoi(nameof(KhongTheoDoi), "Không theo dõi");

    private TrangThaiTheoDoi(string name, string value) : base(name, value) { }
}
