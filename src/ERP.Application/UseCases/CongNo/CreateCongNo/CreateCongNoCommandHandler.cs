using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Domain.Entities.Shared;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.CongNo.CreateCongNo;
public class CreateCongNoCommandHandler : ICommandHandler<CreateCongNoCommand>
{
    private readonly ICongNoRepository _congNoRepository;

    public CreateCongNoCommandHandler(ICongNoRepository congNoRepository)
    {
        _congNoRepository = congNoRepository;
    }

    public async Task<Result> Handle(CreateCongNoCommand request, CancellationToken cancellationToken)
    {
        DateTime tungay = request.tungay.ConvertToDate();
        DateTime denngay = request.denngay.ConvertToDate();

        KhoangThoiGian khoangThoiGian = KhoangThoiGian.Create(tungay,denngay);
        var congno = CongNoSR.Create(
            request.IdKhachHang,
            request.LoaiNV,
            request.TongNo,
            request.NoQuaHan,
            request.NoDenHan,
            khoangThoiGian,
            request.NgayDenHenThanhToan.ConvertToDateOnly(),
            request.SoTienHenThanhToan,
            request.SoTienDuKienVe,
            request.KetQuaThuHoi,
            request.NoNoiBoQuaHan,
            request.TongCo,
            request.CongNoXau,
            request.No_1_30_Ngay,
            request.No_30_45_Ngay,
            request.NoTren60Ngay,
            request.KhachHenChuaThanhToan,
            request.No_1_7_Ngay,
            request.No_7_15_Ngay,
            request.No_15_30_Ngay);

        await _congNoRepository.Add(congno);
        return Result.Success();
    }
}

