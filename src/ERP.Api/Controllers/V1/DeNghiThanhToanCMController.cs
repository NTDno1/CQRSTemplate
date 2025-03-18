using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.CM.CreateDeNghiThanhToanCM;
using ERP.Application.UseCases.DeNghiThanhToanCM.DeleteDeNghiThanhToanCM;
using ERP.Application.UseCases.DeNghiThanhToanCM.ListDeNghiThanhToanCM;
using ERP.Application.UseCases.DeNghiThanhToanCM.UpdateDeNghiThanhToanCM;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/de_nghi_thanh_toan_cm")]
public class DeNghiThanhToanCMController : ApiController
{
    public DeNghiThanhToanCMController(ISender sender) : base(sender)
    {
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateDeNghiThanhToanCM([FromBody] CreateDNThanhToanCMCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> ListDeNghiThanhToanCM([FromQuery] ListDNThanhToanCMQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateDeNghiThanhToanCM([FromBody] UpdateDNThanhToanCMCommand command)
    {
        Result result = await Sender.Send(command);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpDelete("xoa_de_nghi")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteDeNghi(Ulid Id)
    {
        var comand = new DeleteDNThanhToanCMCommand(Id);
        var result = await Sender.Send(comand);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
