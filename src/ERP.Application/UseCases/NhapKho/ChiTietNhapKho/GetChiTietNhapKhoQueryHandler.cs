using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.NhapKho.ChiTietNhapKho;
public sealed class GetChiTietNhapKhoQueryHandler : IQueryHandler<GetChiTietNhapKhoQuery>
{
    public async Task<Result> Handle(GetChiTietNhapKhoQuery request, CancellationToken cancellationToken)
    {
        var data = new
        {
            thongtinchung = "",
            chitiet = ""
        };
        return Result.Success(data);
    }
}
