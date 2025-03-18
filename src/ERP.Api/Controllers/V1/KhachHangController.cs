using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.KhachHang.CreateKhachHang;
using ERP.Application.UseCases.KhachHang.DeleteKhachHang;
using ERP.Application.UseCases.KhachHang.KhachHangDetail;
using ERP.Application.UseCases.KhachHang.ListKhachHang;
using ERP.Application.UseCases.KhachHang.UpdatKhachHang;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/khach_hang")]
public class KhachHangController : ApiController
{
    public KhachHangController(ISender sender) : base(sender)
    {
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateKhachHang([FromBody] CreateKhachHangCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateKhachHang([FromBody] UpdateKhachHangCommand command)
    {
        Result result = await Sender.Send(command);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet("{maKhacHang}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetGetKhachHangById(string maKhacHang)
    {
        var query = new DetailKhachHangQuery(maKhacHang);
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListKhachHang([FromQuery] ListKhachHangQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpDelete("{IdKhachHang}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteKhachHang(Ulid IdKhachHang)
    {
        var comand = new DeleteKhachHangCommand(IdKhachHang);
        var result = await Sender.Send(comand);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
