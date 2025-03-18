using AutoMapper;
using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Responses.KhachHangRespone;

namespace ERP.Application.UseCases.KhachHang.KhachHangDetail;
public class DetailKhachHangQueryHandler : IQueryHandler<DetailKhachHangQuery>
{
    private readonly IKhachHangRepository _khachHangRepository;
    private readonly IMapper _mapper;

    public DetailKhachHangQueryHandler(IKhachHangRepository khachHangRepository, IMapper mapper)
    {
        _khachHangRepository = khachHangRepository;
        _mapper = mapper;
    }

    public async Task<Result> Handle(DetailKhachHangQuery request, CancellationToken cancellationToken)
    {
        DetailKhachHantgRespone khachHangRespone = await _khachHangRepository.GetKhachHang(request.IdKhachHang);
        khachHangRespone.KhachHangLienHe = await _khachHangRepository.GetKhachHangLienHe(request.IdKhachHang);
        khachHangRespone.TaiKhoanNganHangKhachHang = await _khachHangRepository.GetTaiKhoanNganHangKhachHang(request.IdKhachHang);
        khachHangRespone.DanhGiaKhachHangs = await _khachHangRepository.GetDanhGiaKhachHang(request.IdKhachHang);
        khachHangRespone.PhanHoiKhachHangs = await _khachHangRepository.GetPhanHoiKhachHang(request.IdKhachHang);
        khachHangRespone.KhaiHaiQuans = await _khachHangRepository.GetKhaiHaiQuan(request.IdKhachHang);

        if (khachHangRespone != null)
        {
            return Result.Success(khachHangRespone);
        }

        Error err = new Error("NotFound", $"Không tìm thấy số chứng từ!");
        return Result.Failure(err);
    }
}
