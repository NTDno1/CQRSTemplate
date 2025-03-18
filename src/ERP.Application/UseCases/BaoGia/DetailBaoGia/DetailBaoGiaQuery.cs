using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.BaoGia.DetailBaoGia;
public sealed record DetailBaoGiaQuery(
     string idBaoGia
    ) : IQuery;
