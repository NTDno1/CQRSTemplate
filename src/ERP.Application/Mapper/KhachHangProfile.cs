using AutoMapper;
using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Share.Responses.KhachHangRespone;

namespace ERP.Application.Mapper;
public class KhachHangProfile : Profile
{
    public KhachHangProfile()
    {
        CreateMap<KhachHang, KhachHangRespone>().ReverseMap();
    }
}
