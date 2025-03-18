using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;
using ERP.Share.Enumerations;

namespace ERP.Application.UseCases.CM.CreateDeNghiThanhToanCM;
public class CreateDNThanhToanCMCommandHandler : ICommandHandler<CreateDNThanhToanCMCommand>
{
    private readonly IDeNghiThanhToanCMRepository _deNghiThanhToanCMRepository;

    public CreateDNThanhToanCMCommandHandler(IDeNghiThanhToanCMRepository deNghiThanhToanCMRepository)
    {
        _deNghiThanhToanCMRepository = deNghiThanhToanCMRepository;
    }
    public async Task<Result> Handle(CreateDNThanhToanCMCommand request, CancellationToken cancellationToken)
    {
        string maDeNghi = await _deNghiThanhToanCMRepository.GenerateCode(x => x.MaDeNghi, Prefix.DN);

        var dnttCM = Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM.DeNghiThanhToanCM.Create(
            maDeNghi,
            request.noiDungNgheNghiThanhToan,
            request.tongTien,
            request.idKhachHang,
            request.trucThuoc,
            request.nguoiDuyet,
            request.ngayDuyet.ConvertToDate(),
            request.trangThai,
            request.lyDoHuy,
            request.daThanhToan,
            request.nguoiThanhToan,
            request.ngayThanhToan.ConvertToDateOnly(),
            request.hinhThucThanhToan,
            request.thanhToanTheoTaiKhoan,
            request.soTaiKhoan,
            request.nganHang,
            request.chiNhanhNganHang,
            request.nguoiThuHuong,
            request.ngayThanhToanDuKien.ConvertToDateOnly(),
            request.soTienGiamTru);

        await _deNghiThanhToanCMRepository.Add(dnttCM);
        return Result.Success();
    }
}
