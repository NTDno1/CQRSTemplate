using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.BaoGia.CreateBaoGia;
using ERP.Application.UseCases.BaoGia.DeleteBaoGia;
using ERP.Application.UseCases.BaoGia.DetailBaoGia;
using ERP.Application.UseCases.BaoGia.ListBaoGia;
using ERP.Application.UseCases.BaoGia.UpdateBaoGia;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/bao_gia")]
public class BaoGiaController : ApiController
{
    public BaoGiaController(ISender sender) : base(sender)
    {
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateBaoGia([FromBody] CreateBaoGiaCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateKhachHang([FromBody] UpdateBaoGiaCommand command)
    {
        Result result = await Sender.Send(command);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet("{IdBaoGia}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetGetKhachHangById(string IdBaoGia)
    {
        var query = new DetailBaoGiaQuery(IdBaoGia);
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListKhachHang([FromQuery] ListBaoGiaQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpDelete("{IdBaoGia}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteKhachHang(Ulid IdBaoGia)
    {
        var comand = new DeleteBaoGiaCommand(IdBaoGia);
        var result = await Sender.Send(comand);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
