using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.DieuKhoanThanhToan.CreateDieuKhoanThanhToan;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/dieu_khoan_thanh_toan")]
public class DieuKhoanThanhToanController : ApiController
{
    public DieuKhoanThanhToanController(ISender sender) : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListDieuKhoanThanhToan([FromQuery] ListDieuKhoanThanhToanQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateDieuKhoanThanhToan([FromBody] CreateDieuKhoanThanhToanCommand command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
