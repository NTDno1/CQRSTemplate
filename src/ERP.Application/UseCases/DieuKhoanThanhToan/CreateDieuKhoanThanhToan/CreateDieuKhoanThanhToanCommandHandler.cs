using ERP.Domain.Entities.System.DieuKhoanThanhToan;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.DieuKhoanThanhToan.CreateDieuKhoanThanhToan;
public class CreateDieuKhoanThanhToanCommandHandler : ICommandHandler<CreateDieuKhoanThanhToanCommand>
{
    private readonly IDieuKhoanThanhToanRepository _dieuKhoanThanhToanRepository;

    public CreateDieuKhoanThanhToanCommandHandler(IDieuKhoanThanhToanRepository dieuKhoanThanhToanRepository)
    {
        _dieuKhoanThanhToanRepository = dieuKhoanThanhToanRepository;
    }

    public async Task<Result> Handle(CreateDieuKhoanThanhToanCommand request, CancellationToken cancellationToken)
    {
        DateTime? tuNgayNo1 = !string.IsNullOrEmpty(request.dieuKhoanThanhToanNo1.TuNgay) ? request.dieuKhoanThanhToanNo1.TuNgay.ConvertToDate() : null;
        DateTime? denNgayNo1 = !string.IsNullOrEmpty(request.dieuKhoanThanhToanNo1.DenNgay) ? request.dieuKhoanThanhToanNo1.DenNgay.ConvertToDate() : null;

        DateTime? tuNgayNo2 = !string.IsNullOrEmpty(request.dieuKhoanThanhToanNo2.TuNgay) ? request.dieuKhoanThanhToanNo2.TuNgay.ConvertToDate() : null;
        DateTime? denNgayNo2 = !string.IsNullOrEmpty(request.dieuKhoanThanhToanNo2.DenNgay) ? request.dieuKhoanThanhToanNo2.DenNgay.ConvertToDate() : null;

        DateTime? tuNgayNo3 = !string.IsNullOrEmpty(request.dieuKhoanThanhToanNo3.TuNgay) ? request.dieuKhoanThanhToanNo3.TuNgay.ConvertToDate() : null;
        DateTime? denNgayNo3 = !string.IsNullOrEmpty(request.dieuKhoanThanhToanNo3.DenNgay) ? request.dieuKhoanThanhToanNo3.DenNgay.ConvertToDate() : null;

        var dieuKhoanThanhToanNo1 = ERP.Domain.Entities.System.DieuKhoanThanhToan.DieuKhoanThanhToanNo.Create(
            request.dieuKhoanThanhToanNo1.SoThangDuocNo,
            request.dieuKhoanThanhToanNo1.SoNgayDuocNo,
            request.dieuKhoanThanhToanNo1.NgayThanhToan,
            tuNgayNo1,
            denNgayNo1);

        var dieuKhoanThanhToanNo2 = ERP.Domain.Entities.System.DieuKhoanThanhToan.DieuKhoanThanhToanNo.Create(
            request.dieuKhoanThanhToanNo2.SoThangDuocNo,
            request.dieuKhoanThanhToanNo2.SoNgayDuocNo,
            request.dieuKhoanThanhToanNo2.NgayThanhToan,
            tuNgayNo2,
            denNgayNo2);

        var dieuKhoanThanhToanNo3 = ERP.Domain.Entities.System.DieuKhoanThanhToan.DieuKhoanThanhToanNo.Create(
            request.dieuKhoanThanhToanNo3.SoThangDuocNo,
            request.dieuKhoanThanhToanNo3.SoNgayDuocNo,
            request.dieuKhoanThanhToanNo3.NgayThanhToan,
            tuNgayNo3,
            denNgayNo3);

        var dieuKhoanThanhToan = ERP.Domain.Entities.System.DieuKhoanThanhToan.DieuKhoanThanhToan.Create(
            request.thoiHanThanhToan,
            request.loaiDieuKhoanThanhToan,
            dieuKhoanThanhToanNo1,
            dieuKhoanThanhToanNo2,
            dieuKhoanThanhToanNo3,
            request.phanTramThanhToan,
            request.isActiveAuto,
            request.isActiveGiga);
        await _dieuKhoanThanhToanRepository.Add(dieuKhoanThanhToan);
        return Result.Success(dieuKhoanThanhToan.Id);
    }
}
