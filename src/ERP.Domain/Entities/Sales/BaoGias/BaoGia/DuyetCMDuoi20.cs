namespace ERP.Domain.Entities.Sales.BaoGias.BaoGia;



public sealed record DuyetCMDuoi20
{

    public bool CanDuyetCMDuoi20 { get; init; }
    public string? NguoiDuyetCMDuoi20 { get; init; }
    public DateOnly? NgayDuyetCMDuoi20 { get; init; }
    public string? GhiChuDuyetCMDuoi20 { get; init; }

    public static DuyetCMDuoi20 Create(bool canDuyetCMDuoi20, string? nguoiDuyetCMDuoi20, DateOnly? ngayDuyetCMDuoi20, string? ghiChuDuyetCMDuoi20)
    {

        return new DuyetCMDuoi20
        {
            CanDuyetCMDuoi20 = canDuyetCMDuoi20,
            NguoiDuyetCMDuoi20 = nguoiDuyetCMDuoi20,
            NgayDuyetCMDuoi20 = ngayDuyetCMDuoi20,
            GhiChuDuyetCMDuoi20 = ghiChuDuyetCMDuoi20

        };
    }

}
