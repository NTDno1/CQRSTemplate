using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Share.Responses.DeNghiThanhToanCM;
public class DeNghiThanhToanCMResponse
{
    public string MaDeNghi { get; set; }
    public string NoiDungNgheNghiThanhToan { get; set; }
    public decimal TongTien { get; set; }
    public string IdKhachHang { get; set; }
    public string TrucThuoc { get; set; }
    public string NguoiDuyet { get; set; }
    public string NgayDuyet { get;  set; }
    public string TrangThai { get;  set; }
    public string? LyDoHuy { get;  set; }
    public bool DaThanhToan { get;  set; }
    public string NguoiThanhToan { get;  set; }
    public string NgayThanhToan { get;  set; }
    public string HinhThucThanhToan { get;  set; }
    public string ThanhToanTheoTaiKhoan { get; set; }
    public string TaiKhoanNganHangNhan { get; set; }
    public string NgayThanhToanDuKien { get; set; }
    public decimal SoTienGiamTru { get; set; }
}
