using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.HR.CongTacPhi;


public sealed class LoaiCongViec : SmartEnum<LoaiCongViec, string>
{
    public static readonly LoaiCongViec LapDat = new LoaiCongViec(nameof(LapDat), "Lắp đặt");
    public static readonly LoaiCongViec BaoHanh = new LoaiCongViec(nameof(BaoHanh), "Bảo hành");
    public static readonly LoaiCongViec SuaChua = new LoaiCongViec(nameof(SuaChua), "Sửa chữa");
    public static readonly LoaiCongViec KhaoSat = new LoaiCongViec(nameof(KhaoSat), "Khảo sát");


    private LoaiCongViec(string name, string value) : base(name, value) { }
}
