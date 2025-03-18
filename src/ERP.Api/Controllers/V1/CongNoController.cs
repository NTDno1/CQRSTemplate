using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.CongNo.CreateCongNo;
using ERP.Application.UseCases.CongNo.DeleteCongNo;
using ERP.Application.UseCases.CongNo.ListCommentCongNo;
using ERP.Application.UseCases.CongNo.ListCongNo;
using ERP.Application.UseCases.CongNo.ListCongNoThucTe;
using ERP.Application.UseCases.CongNo.UpdateCongNo;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/cong_no_sr")]
public class CongNoController : ApiController
{
    public CongNoController(ISender sender)
        : base(sender)
    {
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListCongNoSR([FromQuery] ListCongNoQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateCongNoSR([FromBody] UpdateCongNoCommand command)
    {
        Result result = await Sender.Send(command);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCongNo([FromBody] CreateCongNoCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet("cong_no_comment")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListCongNoComment([FromQuery] ListCommentQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet("cong_no_thuc_te")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListCongNoThucTe([FromQuery] ListCongNoThucTeQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpDelete("xoa_cong_no")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteCongNo(Ulid Id)
    {
        var comand = new DeleteCongNoCommand(Id);
        var result = await Sender.Send(comand);

        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
