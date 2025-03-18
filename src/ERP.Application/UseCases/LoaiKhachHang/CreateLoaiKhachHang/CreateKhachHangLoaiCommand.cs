using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.LoaiKhachHang.CreateLoaiKhachHang;
public sealed record CreateKhachHangLoaiCommand(
        string tenLoaiKhach,
        string nganhHangApDung,
        Ulid? idLoaiKhachCha,
        bool isReport) : ICommand;
