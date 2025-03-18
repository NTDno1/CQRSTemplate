using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiThanhToanCM.UpdateDeNghiThanhToanCM;
public class UpdateDNThanhToanCMCommandHandler : ICommandHandler<UpdateDNThanhToanCMCommand>
{
    private readonly IDeNghiThanhToanCMRepository _deNghiThanhToanCMRepository;

    public UpdateDNThanhToanCMCommandHandler(IDeNghiThanhToanCMRepository deNghiThanhToanCMRepository)
    {
        _deNghiThanhToanCMRepository = deNghiThanhToanCMRepository;
    }

    public async Task<Result> Handle(UpdateDNThanhToanCMCommand request, CancellationToken cancellationToken)
    {
        ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM.DeNghiThanhToanCM dnttCM = await _deNghiThanhToanCMRepository.FindByIdAsync(request.Id, cancellationToken);
        if (dnttCM == null)
        {
            return Result.Failure<string>(new Error("NotFound", "Không tìm thấy đề nghị thanh toán!"));
        }
        dnttCM.Update(request.hinhThucThanhToan, request.noiDungNgheNghiThanhToan, request.soTaiKhoan, request.nganHang, request.chiNhanhNganHang, request.nguoiThuHuong);

        return Result.Success("Cập nhật thành công");
    }
}
