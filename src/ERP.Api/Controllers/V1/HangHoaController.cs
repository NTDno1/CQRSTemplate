using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.HangHoa.CreateHangHoa;
using ERP.Application.UseCases.HangHoa.CreateNhomHang;
using ERP.Application.UseCases.HangHoa.DeleteHangHoa;
using ERP.Application.UseCases.HangHoa.GetHangHoa;
using ERP.Application.UseCases.HangHoa.UpdateHangHoa;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;

[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/hang_hoa")]
public class HangHoaController : ApiController
{
    public HangHoaController(ISender sender)
        : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetHangHoas([FromQuery] GetHangHoaQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateHangHoaCommand command)
    {
        var result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update([FromBody] UpdateHangHoaCommand command)
    {
        var result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpDelete("{IdHangHoa}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteHangHoa(Ulid IdHangHoa)
    {
        var command = new DeleteHangHoaCommand(IdHangHoa);
        var result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPost("nhom_hang")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateNhomHang([FromBody] CreateNhomHangCommand command)
    {
        var result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
