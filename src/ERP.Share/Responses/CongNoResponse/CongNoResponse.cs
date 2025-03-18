using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Share.Responses.BaoGiaRespone;

namespace ERP.Share.Responses.CongNoResponse;
public class CongNoResponse
{
    public string Id { get; set; }
    public string IdKhachHang { get; set; }
    public string LoaiNV { get; set; }
    public decimal TongNo { get; set; }
    public decimal NoQuaHan { get; set; }
    public decimal NoDenHan { get; set; }
    public string KhoangThoiGian { get; set; }
    public string NgayDenHenThanhToan { get; set; }
    public decimal SoTienHenThanhToan { get; set; }
    public decimal SoTienDuKienVe { get; set; }
    public string KetQuaThuHoi { get; set; }
    public decimal NoNoiBoQuaHan { get; set; }
    public decimal TongCo { get; set; }
    public decimal CongNoXau { get; set; }
    public decimal No_1_30_Ngay { get; set; }
    public decimal No_30_45_Ngay { get; set; }
    public decimal NoTren60Ngay { get; set; }
    public bool KhachHenChuaThanhToan { get; set; }
    public decimal No_1_7_Ngay { get; set; }
    public decimal No_7_15_Ngay { get; set; }
    public decimal No_15_30_Ngay { get; set; }

}

public class CongNoCommentResponse
{
    public string Id { get; set; }
    public string IdCongNo { get; set; }
    public string SaleComment { get; set; }
    public string AcctComment { get; set; }
    public string NoiDungComment { get; set; }
}

public class CongNoThucTeResponse
{
    public string IdKhachHang { get; set; }
    public decimal TongNo { get; set; }
    public decimal TongCo { get; set; }
    public decimal NoQuaHan { get; set; }
    public decimal NoNoiBoQuaHan { get; set; }
    public decimal NoDenHan { get; set; }
    public string KhoangThoiGian { get; set; }
    public string KetQuaThuHoi { get; set; }
    public string KetQuaThuHoiQuaHan { get; set; }
    public string KetQuaThuHoiDenHan { get; set; }
    public string KetQuaThuHoiNgoaiDuKien { get; set; }
    public decimal TongThuHoi { get; set; }
    public bool CongNoXau { get; set; }
}

