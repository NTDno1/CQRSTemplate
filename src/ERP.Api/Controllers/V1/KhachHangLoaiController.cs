using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.LoaiKhachHang.CreateLoaiKhachHang;
using ERP.Application.UseCases.LoaiKhachHang.ListLoaiKhachHang;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/khach_hang_loai")]
public class KhachHangLoaiController : ApiController
{
    public KhachHangLoaiController(ISender sender)
        : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListKhachHangLoai([FromQuery] ListKhachHangLoaiQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateKhachHangLoai([FromBody] CreateKhachHangLoaiCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
