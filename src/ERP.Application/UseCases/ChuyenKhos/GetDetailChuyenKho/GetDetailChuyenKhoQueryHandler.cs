using AutoMapper;
using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Responses.ChuyenKho;

namespace ERP.Application.UseCases.WhChuyenKhos.GetWhChuyenKho;
public sealed class GetWhChuyenKhoQueryHandler : IQueryHandler<GetWhChuyenKhoQuery>
{
    private readonly IChuyenKhoRepository _whChuyenKhoRepository;
    private readonly IMapper _mapper;

    public GetWhChuyenKhoQueryHandler(IChuyenKhoRepository whChuyenKhoRepository, IMapper mapper)
    {
        _whChuyenKhoRepository = whChuyenKhoRepository;
        _mapper = mapper;
    }

    public async Task<Result> Handle(GetWhChuyenKhoQuery request, CancellationToken cancellationToken)
    {
        ChuyenKhoRespone chuyenKhoResone = await _whChuyenKhoRepository.GetDetailWhChuyenKho(request.idChuyenKho);
        if (chuyenKhoResone != null)
        {
            IEnumerable<ChuyenKhoChiTietRespone> chuyenKhoChiTietRespone = await _whChuyenKhoRepository.GetDetailWhChuyenKhoChiTiet(chuyenKhoResone.Id.ToString());
            DetailChuyenKhoRespone whChuyenKhoDetailDTO = new DetailChuyenKhoRespone
            {
                Id = chuyenKhoResone.Id,
                NgayChungTu = chuyenKhoResone.NgayChungTu,
                DienGiai = chuyenKhoResone.DienGiai,
                TrucThuoc = chuyenKhoResone.TrucThuoc,
                HinhThucChuyen = chuyenKhoResone.HinhThucChuyen,
                SoBill = chuyenKhoResone.SoBill,
                KhoXuatHang = chuyenKhoResone.IdKhoXuatHang,
                KhoNhanHang = chuyenKhoResone.IdKhoNhanHang,
                TrangThai = chuyenKhoResone.TrangThai,
                NgayXacNhanXuat = chuyenKhoResone.NgayXacNhanXuat,
                NguoiXacNhanXuat = chuyenKhoResone.NguoiXacNhanXuat,
                NguoiNhanHang = chuyenKhoResone.NguoiNhanHang,
                ThoiGianNhanHang = chuyenKhoResone.ThoiGianNhanHang,
                CanXuatHoaDon = chuyenKhoResone.CanXuatHoaDon,
                SoHoaDon = chuyenKhoResone.SoHoaDon,
                NguoiTao = chuyenKhoResone.NguoiTao,
                TenNguoiTao = chuyenKhoResone.TenNguoiTao,
                NgayTao = chuyenKhoResone.NgayTao,
                TenNguoiXacNhanXuat = chuyenKhoResone.TenNguoiXacNhanXuat,
                NgaySua = chuyenKhoResone.NgaySua,
                TenNguoiSua = chuyenKhoResone.TenNguoiSua,
                ChuyenKhoChiTietRespone = chuyenKhoChiTietRespone.ToList(),
            };
            return Result.Success(whChuyenKhoDetailDTO);
        }

        Error err = new Error("NotFound", $"Không tìm thấy số chứng từ!");
        return Result.Failure(err);
    }
}
