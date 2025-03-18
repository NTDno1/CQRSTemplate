using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.LoaiKhachHang.CreateLoaiKhachHang;
internal class CreateKhachHangLoaiCommandHandler : ICommandHandler<CreateKhachHangLoaiCommand>
{
    private readonly IKhachHangLoaiRepository _khachHangLoaiRepository;

    public CreateKhachHangLoaiCommandHandler(IKhachHangLoaiRepository khachHangLoaiRepository)
    {
        _khachHangLoaiRepository = khachHangLoaiRepository;
    }

    public async Task<Result> Handle(CreateKhachHangLoaiCommand request, CancellationToken cancellationToken)
    {
        var khachHangLoai = KhachHangLoai.Create(request.tenLoaiKhach, request.nganhHangApDung, request.idLoaiKhachCha, request.isReport);
        await _khachHangLoaiRepository.Add(khachHangLoai);
        return Result.Success(khachHangLoai.Id);
    }
}
