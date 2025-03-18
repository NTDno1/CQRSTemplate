using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.DeNghiTraLai.CreateDeNghiTraLai;
using ERP.Application.UseCases.DeNghiTraLai.DeleteDeNghiTraLai;
using ERP.Application.UseCases.DeNghiTraLai.DetailDeNghiTraLai;
using ERP.Application.UseCases.DeNghiTraLai.ListDeNghiTraLai;
using ERP.Application.UseCases.DeNghiTraLai.UpdateDeNghiTraLai;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/de_nghi_tra_lai")]
public class DeNghiTraLaiController : ApiController
{
    public DeNghiTraLaiController(ISender sender) : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetDeNghiTraLaiById([FromQuery] ListDeNghiTraLaiQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet("get_by_id")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListDeNghiTraLai([FromQuery] DetailDeNghiTraLaiQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateDeNghiTraLai([FromBody] CreateDeNghiTraLaiCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateDeNghiTraLai([FromBody] UpdateDeNghiTraLaiCommand command)
    {
        Result result = await Sender.Send(command);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteKhachHang(DeleteDeNghiTraLaiCommand comand)
    {
        var result = await Sender.Send(comand);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
