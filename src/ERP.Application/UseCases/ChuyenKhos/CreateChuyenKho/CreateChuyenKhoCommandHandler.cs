using ERP.Application.UseCases.ChuyenKhos.CreateWhChuyenKho;
using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Enumerations;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.KhoChuyenKhos.CreateKhoChuyenKho;
public sealed class CreateChuyenKhoCommandHandler : ICommandHandler<CreateChuyenKhoCommand>
{
    private readonly IChuyenKhoRepository _whChuyenKhoRepository;

    public CreateChuyenKhoCommandHandler(IChuyenKhoRepository whChuyenKhoRepository)
    {
        _whChuyenKhoRepository = whChuyenKhoRepository;
    }

    public async Task<Result> Handle(CreateChuyenKhoCommand request, CancellationToken cancellationToken)
    {
        DateTime? ngayXacNhanXuat = request.NgayXacNhanXuat?.ConvertToDate();
        DateTime? thoiGianNhanHang = request.ThoiGianNhanHang?.ConvertToDate();

        string maChuyenKho = await _whChuyenKhoRepository.GenerateCode(x => x.MaChuyenKho, Prefix.CK);

        var addWhChuyenKho = ChuyenKho.Create(
            maChuyenKho,
            request.DienGiai,
            request.TrucThuoc,
            request.SoBill,
            request.HinhThucChuyen,
            request.IdKhoXuatHang,
            request.IdKhoNhanHang,
            ngayXacNhanXuat,
            request.NguoiXacNhanXuat,
            request.NguoiNhanHang,
            thoiGianNhanHang,
            request.SoHoaDon);
        await _whChuyenKhoRepository.Add(addWhChuyenKho);
        List<ChuyenKhoChiTiet> whChuyenKhoChiTiets = new List<ChuyenKhoChiTiet>();
        foreach (Share.DTO.AddChuyenKhoChiTietDTO item in request.AddChuyenKhoChiTiets)
        {
            DateTime? ngayNhatHang = item.NgayNhatHang.ConvertToDate();
            var nhatHang = NhatHang.Create(item.SoLuongDaNhat, item.NguoiNhatHang, ngayNhatHang);
            var whChuyenKhoChiTiet = ChuyenKhoChiTiet.Create(
                addWhChuyenKho.Id, item.IdHangHoa, item.MaDieuChinh, item.IdXuatTaiKho, item.IdHangHoa, item.SoLuong, item.DonGia, item.ThanhTien, nhatHang);
            whChuyenKhoChiTiets.Add(whChuyenKhoChiTiet);
        }

        addWhChuyenKho.AddChuyenKhoChiTiet(whChuyenKhoChiTiets);
        var res = new
        {
            message = $"Tạo thành công phiếu: {addWhChuyenKho.Id}",
            result = addWhChuyenKho
        };
        return Result.Success(res);
    }
}
