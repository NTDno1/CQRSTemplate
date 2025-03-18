namespace ERP.Domain.Entities.Shared;


public sealed record DuyetDon
{

    public string? IdUser { get; init; }
    public DateTime? Ngay { get; init; }
    public TrangThaiDonDuyet TrangThai { get; init; }
    public string? GhiChuDuyet { get; init; }


    public static DuyetDon Create(string? idUser, DateTime? ngay, TrangThaiDonDuyet trangThai, string? ghiChuDuyet)
    {

        return new DuyetDon
        {
            IdUser = idUser,
            Ngay = ngay,
            TrangThai = trangThai,
            GhiChuDuyet = ghiChuDuyet
        };
    }

}




