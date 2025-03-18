using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.ChuyenKhos.CreateWhChuyenKho;
using ERP.Application.UseCases.ChuyenKhos.GetListWhChuyenKho;
using ERP.Application.UseCases.ChuyenKhos.UpdateWhChuyenKho;
using ERP.Application.UseCases.WhChuyenKhos.DeleteWhChuyenKho;
using ERP.Application.UseCases.WhChuyenKhos.GetWhChuyenKho;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/kho_chuyen_kho")]
public class KhoChuyenKhoController : ApiController
{
    public KhoChuyenKhoController(ISender sender) : base(sender)
    {
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[Authorize]
    public async Task<IActionResult> CreateWhChuyenKho([FromBody] CreateChuyenKhoCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[Authorize]
    public async Task<IActionResult> UpdateWhChuyenKho([FromBody] UpdateChuyenKhoCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet("chuyen_kho_chi_tiet")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[Authorize]
    public async Task<IActionResult> GetWhChuyenKhoBySoChungTu([FromQuery] GetWhChuyenKhoQuery query)
    {
        Result result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[Authorize]
    public async Task<IActionResult> GetListWhChuyenKho([FromQuery] GetListChuyenKhoQuery query)
    {
        Result result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[Authorize]
    public async Task<IActionResult> DeleteWhChuyenKho([FromBody] DeleteChuyenKhoCommand comand)
    {
        Result result = await Sender.Send(comand);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
