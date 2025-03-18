using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.DeNghiSuaGia.ListDeNghiSuaGia;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/de_nghi_sua_gia")]
public class DeNghiSuaGiaController : ApiController
{
    public DeNghiSuaGiaController(ISender sender)
        : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListDeNghiSuaGia([FromQuery] ListDeNghiSuaGiaQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
