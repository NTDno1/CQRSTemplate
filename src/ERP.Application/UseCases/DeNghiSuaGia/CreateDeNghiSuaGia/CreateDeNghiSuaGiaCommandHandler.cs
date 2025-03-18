using ERP.Domain.Entities.Sales.DeNghi.DeNghiSuaGia;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.DeNghiSuaGia.CreateDeNghiSuaGia;
public class CreateDeNghiSuaGiaCommandHandler : ICommandHandler<CreateDeNghiSuaGiaCommand>
{
    private readonly IDeNghiSuaGiaRepository _deNghiSuaGiaRepository;

    public CreateDeNghiSuaGiaCommandHandler(IDeNghiSuaGiaRepository deNghiSuaGiaRepository)
    {
        _deNghiSuaGiaRepository = deNghiSuaGiaRepository;
    }

    public async Task<Result> Handle(CreateDeNghiSuaGiaCommand request, CancellationToken cancellationToken)
    {
        DateTime? ngayDuyet = request.ngayDuyet?.ConvertToDate();
        var deNghiSuaGia = Domain.Entities.Sales.DeNghi.DeNghiSuaGia.DeNghiSuaGia.Create(
                request.idChiTietXuatKho,
                request.giaNetCu,
                request.giaNetMoi,
                request.giaCMCu,
                request.giaCMMoi,
                request.vatCu,
                request.vatMoi,
                request.maChuan,
                request.lyDoSua,
                request.nguoiDuyet,
                ngayDuyet,
                request.trangThaiDuyet,
                request.ghiChuDuyet);
        await _deNghiSuaGiaRepository.Add(deNghiSuaGia);
        return Result.Success();
    }
}
