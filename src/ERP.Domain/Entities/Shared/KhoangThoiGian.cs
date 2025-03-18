namespace ERP.Domain.Entities.Shared;
public sealed record KhoangThoiGian
{
    private KhoangThoiGian()
    {
    }

    public DateTime? TuNgay { get; init; }

    public DateTime? DenNgay { get; init; }

    public static KhoangThoiGian Create(DateTime? tuNgay, DateTime? denNgay)
    {
        if (tuNgay > denNgay)
        {
            throw new ApplicationException("Đến ngày phải chọn ngày sau từ ngày!");
        }

        return new KhoangThoiGian
        {
            TuNgay = tuNgay,
            DenNgay = denNgay
        };
    }

}
