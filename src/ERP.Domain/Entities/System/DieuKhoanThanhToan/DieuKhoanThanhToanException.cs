using ERP.Domain.Exceptions;

namespace ERP.Domain.Entities.System.DieuKhoanThanhToan;
public class DieuKhoanThanhToanException : BadRequestException
{
    public DieuKhoanThanhToanException(string message)
        : base(message) { }
}
