using ERP.Domain.Abstractions.Repositories;
using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.ChuyenKhos.UpdateWhChuyenKho;
public sealed class UpdateChuyenKhoCommandHandler : ICommandHandler<UpdateChuyenKhoCommand>
{
    private readonly IRepositoryBase<ChuyenKho, Ulid> _whChuyenKhoRepository;

    public UpdateChuyenKhoCommandHandler(IRepositoryBase<ChuyenKho, Ulid> whChuyenKhoRepository)
    {
        _whChuyenKhoRepository = whChuyenKhoRepository;
    }

    public async Task<Result> Handle(UpdateChuyenKhoCommand request, CancellationToken cancellationToken)
    {
        DateTime? ngayXacNhanXuat = request.ngayXacNhanXuat?.ConvertToDate();
        DateTime? thoiGianNhanHang = request.thoiGianNhanHang?.ConvertToDate();
        ChuyenKho whChuyenKho = await _whChuyenKhoRepository.FindByIdAsync(request.idChuyenKho, cancellationToken, x => x.ChuyenKhoChiTiets);
        if (whChuyenKho == null)
        {
            return Result.Failure<string>(new Error("NotFound", "Không tìm thấy phiếu nhập kho!"));
        }

        List<ChuyenKhoChiTiet> chuyenKhoChiTiets = new List<ChuyenKhoChiTiet>();
        List<ChuyenKhoChiTiet> chuyenKhoChiTietBandau = whChuyenKho.ChuyenKhoChiTiets.ToList();
        if (request.chuyenKhoChiTiet != null)
        {
            foreach (var items in request.chuyenKhoChiTiet)
            {
                DateTime? ngayNhatHang = items.NgayNhatHang.ConvertToDate();
                var nhatHang = NhatHang.Create(items.SoLuongDaNhat, items.NguoiNhatHang, ngayNhatHang);
                ChuyenKhoChiTiet? chuyenKhoChiTiet = chuyenKhoChiTietBandau.FirstOrDefault(x => x.Id == items.Id);

                if (chuyenKhoChiTiet != null)
                {
                    chuyenKhoChiTiet.Update(items.IdHangHoa, items.MaDieuChinh, items.IdXuatTaiKho, items.IdNhapTaiKho, items.SoLuong, items.TkNo, items.TkCo, items.DonGia, items.ThanhTien, nhatHang);
                    chuyenKhoChiTiets.Add(chuyenKhoChiTiet);
                }
                else
                {
                    ChuyenKhoChiTiet whChuyenKhoChiTiet = ChuyenKhoChiTiet.Create(whChuyenKho.Id, items.IdHangHoa, items.MaDieuChinh, items.IdXuatTaiKho, items.IdNhapTaiKho, items.SoLuong, items.DonGia, items.ThanhTien, nhatHang);
                    chuyenKhoChiTiets.Add(whChuyenKhoChiTiet);
                }
            }
        }

        whChuyenKho.UpdateDetails(chuyenKhoChiTiets);
        whChuyenKho.Update(request.dienGiai, request.TrucThuoc, request.soBill, request.HinhThucChuyen, request.idKhoXuatHang, request.idKhoNhanHang, ngayXacNhanXuat, request.nguoiXacNhanXuat, request.nguoiNhanHang, thoiGianNhanHang, request.canXuatHoaDon, request.soHoaDon);
        return Result.Success("Tạo thành công");
    }
}
