using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.KhachHang;


public sealed class KhachHangLoai : AggregateRoot
{

    private KhachHangLoai()
    {

    }

    public KhachHangLoai(
        string tenLoaiKhach,
        string nganhHangApDung,
        Ulid? idLoaiKhachCha,
        bool isReport)
    {
        Id = Ulid.NewUlid();
        TenLoaiKhach = tenLoaiKhach;
        NganhHangApDung = nganhHangApDung;
        IdLoaiKhachCha = idLoaiKhachCha;
        IsReport = isReport;
    }

    public string TenLoaiKhach { get; private set; }

    public string NganhHangApDung { get; private set; }

    public Ulid? IdLoaiKhachCha { get; private set; }

    public bool IsReport { get; private set; }

    public static KhachHangLoai Create(
    string tenLoaiKhach,
    string nganhHangApDung,
    Ulid? idLoaiKhachCha,
    bool isReport)
    {
        return new KhachHangLoai(
            tenLoaiKhach,
            nganhHangApDung,
            idLoaiKhachCha,
            isReport);
    }

    public void Update(
    string tenLoaiKhach,
    string nganhHangApDung,
    Ulid? idLoaiKhachCha,
    bool isReport)
    {
        TenLoaiKhach = tenLoaiKhach;
        NganhHangApDung = nganhHangApDung;
        IdLoaiKhachCha = idLoaiKhachCha;
        IsReport = isReport;
    }

}
