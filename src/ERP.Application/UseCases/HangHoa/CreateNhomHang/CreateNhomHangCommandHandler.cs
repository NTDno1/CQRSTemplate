using ERP.Domain.Abstractions.Repositories;
using ERP.Domain.Entities.PURC;
using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.HangHoa.CreateNhomHang;
public sealed class CreateNhomHangCommandHandler : ICommandHandler<CreateNhomHangCommand>
{
    private readonly IRepositoryBase<NhomHang, Ulid> _nhomHangRepository;
    private readonly IHangHoaRepository _hangHoaRepository;

    public CreateNhomHangCommandHandler(IRepositoryBase<NhomHang, Ulid> nhomHangRepository, IHangHoaRepository hangHoaRepository)
    {
        _nhomHangRepository = nhomHangRepository;
        _hangHoaRepository = hangHoaRepository;
    }

    public async Task<Result> Handle(CreateNhomHangCommand request, CancellationToken cancellationToken)
    {
        var nhomHangExist = await _nhomHangRepository.FindSingleAsync(x => x.MaNhomHang == request.maNhomHang);
        if (nhomHangExist != null)
        {
            Error error = new Error("Exist", $"Mã nhóm hàng  {request.maNhomHang} đã tồn tại!");
            return Result.Failure(error);
        }

        List<Domain.Entities.PURC.HangHoa.HangHoa> hangHoas = new List<Domain.Entities.PURC.HangHoa.HangHoa>();
        foreach (Ulid mh in request.hangHoas)
        {
            var hh = await _hangHoaRepository.FindByIdAsync(mh);
            if (hh == null)
            {
                Error error = new Error("NotFound", $"Không tìm thấy mã hàng {mh}");
                return Result.Failure(error);
            }
            hangHoas.Add(hh);
        }

        var nhomHang = NhomHang.Create(request.maNhomHang, request.idNhomHangCha, request.phanLoaiNhom, request.ghiChu, request.muaHangPhuTrach, request.muaHangPhuTrachNuocNgoai, request.leader, request.sub, hangHoas);
        await _nhomHangRepository.Add(nhomHang);
        return Result.Success(nhomHang.Id);
    }
}
