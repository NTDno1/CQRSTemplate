using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.KhachHang.KhachHangDetail;
public sealed record DetailKhachHangQuery(
    string IdKhachHang
    ) : IQuery;
