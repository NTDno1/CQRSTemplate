using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.KhachHangLienHe.ListKhachHangLienHe;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/khach_hang_lien_he")]
public class KhachHangLienHeController : ApiController
{
    public KhachHangLienHeController(ISender sender) : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetListKhachHangLoai([FromQuery] ListKhachHangLienHeQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
