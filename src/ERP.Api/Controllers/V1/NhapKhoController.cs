using Asp.Versioning;
using ERP.Api.Abstractions;
using ERP.Application.UseCases.NhapKho.ChiTietNhapKho;
using ERP.Application.UseCases.NhapKho.DanhSachNhapKho;
using ERP.Share.Abstractions.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Api.Controllers.V1;
[ApiVersion(ApiVersions.V1)]
[Route("api/v{version:apiVersion}/nhapkho")]
public class NhapKhoController : ApiController
{
    public NhapKhoController(ISender sender) : base(sender)
    {

    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DanhSachNhapKho([FromQuery] DanhSachNhapKhoQuery command)
    {
        Result result = await Sender.Send(command);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> ChiTietNhapKho(Ulid id)
    {
        GetChiTietNhapKhoQuery query = new GetChiTietNhapKhoQuery(id);
        Result result = await Sender.Send(query);
        return result.IsFailure ? HandlerFailure(result) : Ok(result);
    }
}
