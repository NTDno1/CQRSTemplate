using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init_Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HR_CongTacPhiPhuongTien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdDeNghiCongTacPhi = table.Column<string>(type: "char(26)", nullable: false),
                    PhiPhuongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoKilomet = table.Column<float>(type: "real", nullable: false),
                    PhuongTien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuPhuongTien = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_CongTacPhiPhuongTien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HR_NV_CongTacPhi",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaSoDeNghi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Thu = table.Column<int>(type: "int", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaDiem = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    LoaiCongViec = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoiDungCongViec = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SoGioLamThem = table.Column<float>(type: "real", nullable: false),
                    TienAnLamThem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhiPhuongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhuCapLuuTru = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThuPhong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChiPhiKhac = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdUserDeNghi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayDeNghi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TruongPhongDuyet = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayTruongPhongDuyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiTruongPhongDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuTruongPhongDuyet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    KeToanDuyet = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayKeToanDuyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiKeToanDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuKeToanDuyet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TrangThaiThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TongThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdUserThanhToan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaHuy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUserHuy = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    LyDoHuy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TrucThuoc = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ThoiGianDiLai = table.Column<DateOnly>(type: "date", nullable: true),
                    KeToanGhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ThoiGianTinhPhuCap = table.Column<DateOnly>(type: "date", nullable: true),
                    TongThanhToanThucTe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CongTacBenNgoai = table.Column<bool>(type: "bit", nullable: false),
                    CheckTruocKhiDuyetB1 = table.Column<bool>(type: "bit", nullable: false),
                    TamTruQuaDem = table.Column<bool>(type: "bit", nullable: false),
                    DiDuongXa = table.Column<bool>(type: "bit", nullable: false),
                    DiemDi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DiemDen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TienAnSang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienAnTrua = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_NV_CongTacPhi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutboxMessages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OccurredOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProcessedOnUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutboxMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PURC_NhomHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaNhomHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IdNhomHangCha = table.Column<string>(type: "char(26)", nullable: true),
                    PhanLoaiNhom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    MuaHangPhuTrach = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    MuaHangPhuTrachNuocNgoai = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Leader = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Sub = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURC_NhomHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PURC_NhomHang_PURC_NhomHang_IdNhomHangCha",
                        column: x => x.IdNhomHangCha,
                        principalTable: "PURC_NhomHang",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_BaoGia",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    SoBaoGia = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayBaoGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    IdLienHe = table.Column<string>(type: "char(26)", nullable: false),
                    HieuLucBaoGia = table.Column<int>(type: "int", nullable: false),
                    IdDieuKhoanThanhToan = table.Column<string>(type: "char(26)", nullable: false),
                    IdDieuKhoanThanhToanKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    ThanhTienNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienHang0 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThueGTGT0 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienHang8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThueGTGT8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienHang10 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThueGTGT10 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThuDichVuVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoaiDon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThaiDon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LyDoTruot = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NgayTruot = table.Column<DateOnly>(type: "date", nullable: true),
                    TrangThaiDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LyDoHuyDuyet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    KhaNangTrung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsBaoGiaQuanTrong = table.Column<bool>(type: "bit", nullable: false),
                    SR = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SR2 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SA = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IdCTKM = table.Column<string>(type: "char(26)", nullable: true),
                    ChiNhanh = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    KhoXuLy = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NguoiNhanHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NgayDuKienGiao = table.Column<DateOnly>(type: "date", nullable: true),
                    SoLuongComment = table.Column<int>(type: "int", nullable: false),
                    CanDuyetCMDuoi20 = table.Column<bool>(type: "bit", nullable: false),
                    NguoiDuyetCMDuoi20 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayDuyetCMDuoi20 = table.Column<DateOnly>(type: "date", nullable: true),
                    GhiChuDuyetCMDuoi20 = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IASHoTro1 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IASHoTro2 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_BaoGia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_CongNoSR",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    LoaiNV = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TongNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoQuaHan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoDenHan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayDenHenThanhToan = table.Column<DateOnly>(type: "date", nullable: false),
                    SoTienHenThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoTienDuKienVe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KetQuaThuHoi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NoNoiBoQuaHan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongCo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CongNoXau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    No_1_30_Ngay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    No_30_45_Ngay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoTren60Ngay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhachHenChuaThanhToan = table.Column<bool>(type: "bit", nullable: false),
                    No_1_7_Ngay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    No_7_15_Ngay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    No_15_30_Ngay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_CongNoSR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_CongNoSRThucTe",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    TongNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongCo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoQuaHan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoNoiBoQuaHan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoDenHan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KetQuaThuHoi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    KetQuaThuHoiQuaHan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    KetQuaThuHoiDenHan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    KetQuaThuHoiNgoaiDuKien = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TongThuHoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CongNoXau = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_CongNoSRThucTe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_CTKM",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    TenCTKM = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodeCTKM = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhanLoai = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NoiDungTruyenThong = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_CTKM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_DeNghiSuaGia",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdChiTietXuatKho = table.Column<string>(type: "char(26)", nullable: false),
                    GiaNetCu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaNetMoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaCMCu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaCMMoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatCu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatMoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaChuan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LyDoSua = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NguoiDuyet = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayDuyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuDuyet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_DeNghiSuaGia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_DeNghiThanhToanCM",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaDeNghi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NoiDungNgheNghiThanhToan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    TrucThuoc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NguoiDuyet = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayDuyet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LyDoHuy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DaThanhToan = table.Column<bool>(type: "bit", nullable: false),
                    NguoiThanhToan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayThanhToan = table.Column<DateOnly>(type: "date", nullable: false),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThanhToanTheoTaiKhoan = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SoTaiKhoan = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NganHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChiNhanhNganHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NguoiThuHuong = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NgayThanhToanDuKien = table.Column<DateOnly>(type: "date", nullable: false),
                    SoTienGiamTru = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_DeNghiThanhToanCM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_DeNghiTraLai",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaDeNghi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayDeNghi = table.Column<DateOnly>(type: "date", nullable: false),
                    NguoiDeNghi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    MaNhatHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    SoPhieuXuatKho = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NguoiTraLai = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    LyDoDeNghi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LeaderDuyet = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayLeaderDuyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiLeaderDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuLeaderDuyet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    KyThuatDuyet = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayKyThuatDuyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiKyThuatDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuKyThuatDuyet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    GhiChuDonHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CanDiLayHang = table.Column<bool>(type: "bit", nullable: false),
                    DiaChiLayHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NguoiGiaoHangThucTe = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    GhiChuGiaoNhan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DaNhapKho = table.Column<bool>(type: "bit", nullable: false),
                    SoPhieuNhapKho = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TrucThuoc = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    IdKhoNhapHang = table.Column<string>(type: "char(26)", nullable: true),
                    HinhThucTraLai = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SoTienPhiNhapLai = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LyDoThuPhiNhapLai = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_DeNghiTraLai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_DuyetXuatTruocHan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    NguoiDeNghi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayDeNghi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdXuatKho = table.Column<string>(type: "char(26)", nullable: false),
                    NgayTinhCongNoGoc = table.Column<DateOnly>(type: "date", nullable: false),
                    NgayTinhCongNoMoi = table.Column<DateOnly>(type: "date", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NguoiDuyet = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayDuyet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThaiDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuDuyet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_DuyetXuatTruocHan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale_KH",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdKhachHangCha = table.Column<string>(type: "char(26)", nullable: true),
                    MaKhachHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TenCongTy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DiaChiVanPhong = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DiaChiXuatHoaDon = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EmailNhanHoaDon = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    MaSoThue = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Website = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SoNhaDuongPhoGiaoHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    QuanHuyenGiaoHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TinhThanhPhoGiaoHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    HoaDonMacDinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChuHoaDonMacDinh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IdLoaiKhach = table.Column<string>(type: "char(26)", nullable: false),
                    NganhNghe = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    KhuCongNghiep = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NguonGocKhachHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SR = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    SR_DangKy = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    SR2 = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    SR2_DangKy = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    SA = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    SA_DangKy = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    QuanLy = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    BU = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    GhiChuKhachHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    HoSoThanhToan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IdDieuKhoanThanhToan = table.Column<string>(type: "char(26)", nullable: false),
                    IdDieuKhoanThanhToanNoiBo = table.Column<string>(type: "char(26)", nullable: false),
                    TinhTrangHoatDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NguoiDaiDien = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ChucVuNguoiDaiDien = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CMNDNguoiDaiDien = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    CanHDNT = table.Column<bool>(type: "bit", nullable: true),
                    DaCoHDNT = table.Column<bool>(type: "bit", nullable: true),
                    KyPO = table.Column<bool>(type: "bit", nullable: true),
                    DanhGiaKhachHang = table.Column<int>(type: "int", nullable: true),
                    NgungCapHang = table.Column<bool>(type: "bit", nullable: true),
                    GhiChuCongNo = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DongDau = table.Column<bool>(type: "bit", nullable: true),
                    InTheoMauMacDinh = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    KhoMacDinh = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    TemMacDinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiayChungNhanDauTu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CanGiayChungNhanDauTu = table.Column<bool>(type: "bit", nullable: true),
                    NgayCapGiayChungNhanDauTu = table.Column<DateOnly>(type: "date", nullable: true),
                    CanYeuCauXacNhanCongNo = table.Column<bool>(type: "bit", nullable: true),
                    HienGiaKhiInPhieuXuatKho = table.Column<bool>(type: "bit", nullable: true),
                    DSE = table.Column<bool>(type: "bit", nullable: true),
                    VendorStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HeThongKhachHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MangKinhDoanh = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KhachHangChaId = table.Column<string>(type: "char(26)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale_KH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sale_KH_Sale_KH_KhachHangChaId",
                        column: x => x.KhachHangChaId,
                        principalTable: "Sale_KH",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_EmailNhanHoaDon",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    EmailNhanHoaDon = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_EmailNhanHoaDon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_HopDong",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    Nam = table.Column<int>(type: "int", nullable: false),
                    LoaiHopDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NgayHopDong = table.Column<DateOnly>(type: "date", nullable: true),
                    SoHopDong = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SoQuyen = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SoThuTu = table.Column<int>(type: "int", nullable: false),
                    DieuKhoanThanhToan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    HanMucTinDung = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NgayHetHan = table.Column<DateOnly>(type: "date", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaHan1Nam = table.Column<bool>(type: "bit", nullable: false),
                    GiaHanHangNam = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_HopDong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_Loai",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    TenLoaiKhach = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NganhHangApDung = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    IdLoaiKhachCha = table.Column<string>(type: "char(26)", nullable: true),
                    IsReport = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_Loai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_NganhNghe",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    NganhNghe = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IdLoaiKhach = table.Column<string>(type: "char(26)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_NganhNghe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_ChiNhanh",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaChiNhanh = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TenChiNhanh = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ThuTuBaoCao = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_ChiNhanh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_DieuKhoanThanhToan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    ThoiHanThanhToan = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LoaiDieuKhoanThanhToan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SoThangDuocNo1 = table.Column<int>(type: "int", nullable: false),
                    SoNgayDuocNo1 = table.Column<int>(type: "int", nullable: false),
                    NgayThanhToan1 = table.Column<int>(type: "int", nullable: false),
                    TuNgay1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoThangDuocNo2 = table.Column<int>(type: "int", nullable: false),
                    SoNgayDuocNo2 = table.Column<int>(type: "int", nullable: false),
                    NgayThanhToan2 = table.Column<int>(type: "int", nullable: false),
                    TuNgay2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoThangDuocNo3 = table.Column<int>(type: "int", nullable: false),
                    SoNgayDuocNo3 = table.Column<int>(type: "int", nullable: false),
                    NgayThanhToan3 = table.Column<int>(type: "int", nullable: false),
                    TuNgay3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhanTramThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActiveAuto = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveGiga = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_DieuKhoanThanhToan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_IPWan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    Ip = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MaVanPhong = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_IPWan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PhongBan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaPhongBan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TenPhongBan = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TrucThuocPhongBan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TruongPhong = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    PhoPhong = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PhongBan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_VanPhong",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaVanPhong = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TenVanPhong = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_VanPhong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wh_ChuyenKho",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaChuyenKho = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayChungTu = table.Column<DateOnly>(type: "date", nullable: false),
                    DienGiai = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    TrucThuoc = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    HinhThucChuyen = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    SoBill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdKhoXuatHang = table.Column<string>(type: "char(26)", nullable: true),
                    IdKhoNhanHang = table.Column<string>(type: "char(26)", nullable: true),
                    NgayXacNhanXuat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiXacNhanXuat = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiNhanHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    ThoiGianNhanHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CanXuatHoaDon = table.Column<bool>(type: "bit", nullable: false),
                    SoHoaDon = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wh_ChuyenKho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WH_DanhSachKho",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    TenKho = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TrucThuocKho = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SetBaoCao = table.Column<bool>(type: "bit", nullable: false),
                    QrId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_DanhSachKho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WH_NhapKho",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    SoChungTu = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayChungTu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHoachToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiPhieu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LoaiNhapKho = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MaDoiTuong = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    KtPhuTrach = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiGiaoHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    DienGiai = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    NhanVienMuaHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ThanhTienHang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThueGtgt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrucThuoc = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    SoHoaDonNhaCungCap = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    NgayHoaDonNhaCungCap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaSoPo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Khoa = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    KhoNhanHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    DaTraLaiNcc = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DaChiTien = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SoTienDaChi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaDuHoaDon = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TongTienPhiVanChuyen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdDieuKhoanThanhToan = table.Column<string>(type: "char(26)", nullable: true),
                    IdDieuKhoanThanhToanNoiBo = table.Column<string>(type: "char(26)", nullable: true),
                    TrangThaiHoaDon = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    GhiChuHoaDon = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    LoaiHoaDon = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    IsTachPhieu = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SaCare = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SrCare = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SoTienDaDeNghiThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TyGiaUsdRmb = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TiGiaRmbVanChuyen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChiPhiSoVoiInvoice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaNhaCungCapNuocNgoai = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    PhiBank = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhiThongQuan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhiXangDau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CanDiLayHang = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    MaVanDonLayHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SoBill = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_NhapKho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WH_XuatKho",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    SoChungTu = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NgayChungTu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTinhCongNo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayNghiemThu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHoaDonHaiQuan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoaiXuatKho = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    SdtNguoiNhan = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LyDoXuat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SR = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SA = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TrucThuoc = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    MaDoiTuong = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    IdBaoGia = table.Column<string>(type: "char(26)", nullable: true),
                    ThanhTienHang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienHang0 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienHang8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienHang10 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThue_GTGT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThue_GTGT0 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThue_GTGT8 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThue_GTGT10 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HoaDonChungTu = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TenCongTyXuatHoaDon = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DiaChiXuatHoaDon = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Mst = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    EmailNhanHoaDon = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    DaXuatHoaDon = table.Column<bool>(type: "bit", nullable: false),
                    XuatHoaDonTuCongTy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    EmailHoaDon = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    SoHoaDonThucTe = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayHoaDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YeuCauXuatHoaDon = table.Column<bool>(type: "bit", nullable: false),
                    ThoiGianTichYeuCauXuatHD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GhiChuHoaDon = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DaGhiSo = table.Column<bool>(type: "bit", nullable: false),
                    NgayGhiSo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiGhiSo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Khoa = table.Column<bool>(type: "bit", nullable: false),
                    SoPoKhach = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    FileDinhKem = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    GhiChuChoGiaoNhan = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    HinhThucGiaoHang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ThongTinNhaXe = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    SoBill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DaPacking = table.Column<bool>(type: "bit", nullable: false),
                    DangPacking = table.Column<bool>(type: "bit", nullable: false),
                    TemXuatTheo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    TrongLuong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoKien = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ViTriDeHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DaGiaoHang = table.Column<bool>(type: "bit", nullable: false),
                    MaVach = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    BenChiuPhi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    KhoXuLy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    InTheoMau = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    DaThanhToan = table.Column<bool>(type: "bit", nullable: false),
                    SoTienDaThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdDieuKhoanThanhToan = table.Column<string>(type: "char(26)", nullable: false),
                    IdDieuKhoanThanhToanNoiBo = table.Column<string>(type: "char(26)", nullable: false),
                    SR2 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    ThanhTienNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienChenhLech = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongChiPhiHoaDon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThucNhanCuaKhach = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoTienDaThanhToanCM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaInPhieu = table.Column<bool>(type: "bit", nullable: false),
                    HienGiaTien = table.Column<bool>(type: "bit", nullable: false),
                    DaChuyenCongNoSan = table.Column<bool>(type: "bit", nullable: false),
                    SoTienThuHo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NguoiXacNhan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IsTachPhieu = table.Column<bool>(type: "bit", nullable: false),
                    SoTienCanThu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienThuDichVuVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaDichVuVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YeuCauPxkHaiQuan = table.Column<bool>(type: "bit", nullable: false),
                    DaXuatPxkHaiQuan = table.Column<bool>(type: "bit", nullable: false),
                    NgayPxkHaiQuan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GhiChuPxkHaiQuan = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ThoiGianTichXuatPxkHaiQuan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaSoPxkHaiQuan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguonGocDonHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdCtkm = table.Column<string>(type: "char(26)", nullable: true),
                    DaChotCtkm = table.Column<bool>(type: "bit", nullable: false),
                    MaVoucher = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TenSanTmdt = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TenShopTmdt = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NgayTaoTmdt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaVanDonViettelPost = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_XuatKho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PURC_HangHoa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    MaChuan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    HsCode = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    ThongSoKyThuat = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TenHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IdNhomHang = table.Column<string>(type: "char(26)", nullable: true),
                    DonViTinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KhoiLuong = table.Column<float>(type: "real", nullable: true),
                    XuatXu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Vat = table.Column<int>(type: "int", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBan1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBan2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBan3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBan4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBan5 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ck1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ck2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ck3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ck4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ck5 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaChuyenDoi = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LinkSanPham = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    PhuKienDiKem = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SoNgayCapHang = table.Column<int>(type: "int", nullable: true),
                    IsTachMa = table.Column<bool>(type: "bit", nullable: true),
                    TinhTrangHangHoa = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    DongSanPham = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    MangKinhDoanh = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    GiaDaiLy = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PhanLoaiHangHoa = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TenHangBaoCao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURC_HangHoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PURC_HangHoa_PURC_NhomHang_IdNhomHang",
                        column: x => x.IdNhomHang,
                        principalTable: "PURC_NhomHang",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PermissionRole",
                columns: table => new
                {
                    PermissionsId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<string>(type: "char(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRole", x => new { x.PermissionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_PermissionRole_Permission_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_BaoGiaChiTiet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdBaoGia = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    MaDieuChinh = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TenHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IdNhomHang = table.Column<string>(type: "char(26)", nullable: true),
                    ItemCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BaoHanh = table.Column<int>(type: "int", nullable: false),
                    DonGiaNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaMoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaDichVuVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienNet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThanhTienHang = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThueGTGT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThueDichVuVat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TongThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PhanTramCM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThueTNDN = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TienThueTNDN = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TienKhachNhan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThoiGianGiaoHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdKhoXuLy = table.Column<string>(type: "char(26)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: true),
                    HinhAnhMinhHoa = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    Discontinue = table.Column<bool>(type: "bit", nullable: false),
                    NoiDungYeuCauHoiHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    MaXinGia = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    TrangThaiDuyetGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaBanThucTe1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBanThucTe2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBanThucTe3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaBanThucTe4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaGMinTinhThuong = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LaMaKhuyenMai = table.Column<bool>(type: "bit", nullable: false),
                    LaMaLo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_BaoGiaChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_BaoGiaChiTiet_SALE_BaoGia_IdBaoGia",
                        column: x => x.IdBaoGia,
                        principalTable: "SALE_BaoGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_BaoGiaComment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdBaoGia = table.Column<string>(type: "char(26)", nullable: false),
                    NoiDungComment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsGiaTri = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_BaoGiaComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_BaoGiaComment_SALE_BaoGia_IdBaoGia",
                        column: x => x.IdBaoGia,
                        principalTable: "SALE_BaoGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_BaoGiaLyDoTruot",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdBaoGia = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    GiaHienTai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LyDoChiTiet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TenDoiThu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_BaoGiaLyDoTruot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_BaoGiaLyDoTruot_SALE_BaoGia_IdBaoGia",
                        column: x => x.IdBaoGia,
                        principalTable: "SALE_BaoGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_CongNoSRComment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdCongNo = table.Column<string>(type: "char(26)", nullable: false),
                    SaleComment = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    AcctComment = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NoiDungComment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_CongNoSRComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_CongNoSRComment_SALE_CongNoSR_IdCongNo",
                        column: x => x.IdCongNo,
                        principalTable: "SALE_CongNoSR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_CTKMChaoKhachHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdCTKM = table.Column<string>(type: "char(26)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    IsThamGia = table.Column<bool>(type: "bit", nullable: false),
                    IsQuanTam = table.Column<bool>(type: "bit", nullable: false),
                    TargetChao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TargetChot = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsKhachHangDongYMua = table.Column<bool>(type: "bit", nullable: false),
                    SaleThemKhach = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_CTKMChaoKhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_CTKMChaoKhachHang_SALE_CTKM_IdCTKM",
                        column: x => x.IdCTKM,
                        principalTable: "SALE_CTKM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_DeNghiThanhToanCMChiTiet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdDeNghi = table.Column<string>(type: "char(26)", nullable: false),
                    IdXuatKho = table.Column<string>(type: "char(26)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_DeNghiThanhToanCMChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_DeNghiThanhToanCMChiTiet_SALE_DeNghiThanhToanCM_IdDeNghi",
                        column: x => x.IdDeNghi,
                        principalTable: "SALE_DeNghiThanhToanCM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_DeNghiTraLaiChiTiet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdDeNghiTraLai = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    MaDieuChinh = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaVon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ThueGTGT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdChiTietXuatKho = table.Column<string>(type: "char(26)", nullable: false),
                    DaNhapKho = table.Column<bool>(type: "bit", nullable: false),
                    SoLuongDaNhap = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_DeNghiTraLaiChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_DeNghiTraLaiChiTiet_SALE_DeNghiTraLai_IdDeNghiTraLai",
                        column: x => x.IdDeNghiTraLai,
                        principalTable: "SALE_DeNghiTraLai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_DanhGiaKhachHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    NganhNghe = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NamThanhLap = table.Column<int>(type: "int", nullable: false),
                    SoLuongNhanVien = table.Column<int>(type: "int", nullable: false),
                    NguoiQuyetDinhMuaHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SanPhamQuanTam = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    HangQuanTam = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CoNhaXuong = table.Column<bool>(type: "bit", nullable: true),
                    SanLuongSanXuat = table.Column<int>(type: "int", nullable: false),
                    DoiThuCanhTranh = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    CoHoiPhatTrien = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    HopDongDaKy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IdCTKMThamGia = table.Column<string>(type: "char(26)", nullable: true),
                    DuAnTiemNangSapToi = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TinhHinhTaiChinh = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LuuY = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_DanhGiaKhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_KH_DanhGiaKhachHang_Sale_KH_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Sale_KH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_KhaiHaiQuan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    ChiCucHaiQuan = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MaDiaDiemLuuKhoHangChoThongQuanDuKien = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DiaDiemDoHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DiaDiemDichChoVanChuyenBaoThue = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GhiChuLamHaiQuanMayDau = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    GhiChuChungTuNhapKhachHangCanCheck = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ThongTinLienHeKhachHang = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    BoChungTuBanCung = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TermOfSale = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    TenTiengAnh = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_KhaiHaiQuan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_KH_KhaiHaiQuan_Sale_KH_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Sale_KH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_LienHe",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    TenLienHe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_LienHe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_KH_LienHe_Sale_KH_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Sale_KH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_PhanHoiKhachHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    NgayPhanHoi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUserPhanHoi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    NoiDungPhanHoi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    LoaiPhanHoi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CoGiaTri = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_PhanHoiKhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_KH_PhanHoiKhachHang_Sale_KH_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Sale_KH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SALE_KH_TaiKhoanNganHang",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    SoTaiKhoan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    IdKhachHang = table.Column<string>(type: "char(26)", nullable: false),
                    LoaiTaiKhoan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NganHang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ChiNhanh = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TinhThanhPho = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE_KH_TaiKhoanNganHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALE_KH_TaiKhoanNganHang_Sale_KH_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Sale_KH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHashed = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PasswordConfirmationHashed = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Avatar = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IdPhongBan = table.Column<string>(type: "char(26)", nullable: false),
                    NoiLamViec = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VanPhongId = table.Column<string>(type: "char(26)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_User_Sys_PhongBan_IdPhongBan",
                        column: x => x.IdPhongBan,
                        principalTable: "Sys_PhongBan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_User_Sys_VanPhong_VanPhongId",
                        column: x => x.VanPhongId,
                        principalTable: "Sys_VanPhong",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WH_ChuyenKhoChiTiet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdChuyenKho = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    MaDieuChinh = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    IdXuatTaiKho = table.Column<string>(type: "char(26)", nullable: true),
                    IdNhapTaiKho = table.Column<string>(type: "char(26)", nullable: true),
                    SoLuong = table.Column<decimal>(type: "decimal(8,3)", nullable: false),
                    Tk_No = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Tk_Co = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongDaNhat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NguoiNhatHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayNhatHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_ChuyenKhoChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WH_ChuyenKhoChiTiet_Wh_ChuyenKho_IdChuyenKho",
                        column: x => x.IdChuyenKho,
                        principalTable: "Wh_ChuyenKho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WH_NhapKhoChiTiet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdNhapKho = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    MaDieuChinh = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TkNo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    TkCo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    TkGiaVon = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    TkThue = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoLuong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienHang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuyDoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DienGiaiThue = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ThueGtgt = table.Column<int>(type: "int", nullable: false),
                    TienThueGtgt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoHoaDon = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgayHoaDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DonGiaVon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienVon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaTriNhapKho = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TkKho = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MaKhoCon = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TongThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    DaTraLaiNhaCungCap = table.Column<bool>(type: "bit", nullable: false),
                    SoLuongDaTra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdCtTraLai = table.Column<string>(type: "char(26)", nullable: true),
                    IdTechMuaHang = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    MaVach = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DaXepHang = table.Column<bool>(type: "bit", nullable: false),
                    SoLuongDaXep = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoTienDaThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaThanhToan = table.Column<bool>(type: "bit", nullable: false),
                    DonGiaBaoDiNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhiVC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TiGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienTruocThue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienTruocThue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienTinhThue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThueNhapKhau = table.Column<int>(type: "int", nullable: false),
                    TienThueNhapKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaPhiVanChuyen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienUsd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoaiTien = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    ChietKhauKhac = table.Column<int>(type: "int", nullable: false),
                    SoTienChietKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienVatChietKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienTinhCongNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienTinhGiaVon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuyDoiTongTienTinhCongNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    XacNhanChietKhau = table.Column<bool>(type: "bit", nullable: false),
                    TongTienChietKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaDoiTru = table.Column<bool>(type: "bit", nullable: false),
                    SoTienDoiTru = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChuCongNoCt = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    PrCanXuLyDauVao = table.Column<bool>(type: "bit", nullable: false),
                    PrTichXuLyDauVao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayThuMuaXuLyDauVao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KtTichHoaDonCham = table.Column<bool>(type: "bit", nullable: false),
                    KtTichCham = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayKtTichHoaDonCham = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_NhapKhoChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WH_NhapKhoChiTiet_WH_NhapKho_IdNhapKho",
                        column: x => x.IdNhapKho,
                        principalTable: "WH_NhapKho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WH_XuatKhoChiTiet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdXuatKho = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    MaDieuChinh = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Dvt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SoLuong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TkCo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TkNo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TkGiaVon = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TkKho = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    DonGiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienHang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaVon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienVon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuyDoi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaKhoCon = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ThueGtgt = table.Column<int>(type: "int", nullable: false),
                    TienThueGtgt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaiKhoanThue = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IdCtBh = table.Column<int>(type: "int", nullable: true),
                    DaTraLaiHang = table.Column<bool>(type: "bit", nullable: false),
                    SoLuongDaTra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaGhiSo = table.Column<bool>(type: "bit", nullable: false),
                    SlCnDaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CnDaNhapHet = table.Column<bool>(type: "bit", nullable: false),
                    MaNhomHang = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    MaKhoBanDau = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    DaPacking = table.Column<bool>(type: "bit", nullable: false),
                    SoLuongPacking = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaBaoDiNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTienNet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoaiTien = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TyGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThueTndn = table.Column<int>(type: "int", nullable: false),
                    TienThueTndn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhachNhanDuoc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienTinhCongNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuyDoiTongTienTinhCongNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChietKhauKhac = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoTienChietKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienVatChietKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    XacNhanChietKhau = table.Column<bool>(type: "bit", nullable: false),
                    LoSanXuat = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    SoPoMaHang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HangGiamGia = table.Column<bool>(type: "bit", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    CachXuLy = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DaXuLy = table.Column<bool>(type: "bit", nullable: false),
                    NguoiXuLy = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayXuLy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoTienDoiTruCT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaDoiTruCt = table.Column<bool>(type: "bit", nullable: false),
                    GhiChuCongNoCt = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    AnPhieu = table.Column<bool>(type: "bit", nullable: false),
                    DaDuyetHoaDon = table.Column<bool>(type: "bit", nullable: false),
                    CanDuyetHoaDon = table.Column<bool>(type: "bit", nullable: false),
                    LyDoDuyetXuatHoaDon = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    NgayDuyetXuatHoaDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KtDuyetXuatHoaDon = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    PrNoteHoaDonNcc = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ErpNoteHoaDonNcc = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    SanDaNhat = table.Column<bool>(type: "bit", nullable: false),
                    TienThuDichVuVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaDichVuVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CmCu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BaoHanh = table.Column<int>(type: "int", nullable: false),
                    LoaiTinhTrangHH = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    NgayDuKienHangVe = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoLuongCoSan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongXuatHoaDon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemCode = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SoPoSamSung = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    IsMaQtCtkm = table.Column<bool>(type: "bit", nullable: false),
                    TroGiaShopee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoChungTuBaoHanh = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_XuatKhoChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WH_XuatKhoChiTiet_WH_XuatKho_IdXuatKho",
                        column: x => x.IdXuatKho,
                        principalTable: "WH_XuatKho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PURC_HinhAnhHangHoa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdHangHoa = table.Column<string>(type: "char(26)", nullable: false),
                    LinkAnh = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURC_HinhAnhHangHoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PURC_HinhAnhHangHoa_PURC_HangHoa_IdHangHoa",
                        column: x => x.IdHangHoa,
                        principalTable: "PURC_HangHoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HR_WFH",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    MaDeNghi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    IdUser = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdUserDuyetDon = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NgayDuyetDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoiDungHuyDuyet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TrangThaiDuyet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThaiXuLy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThaiTheoDoi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NgayXoa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "varchar(20)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_WFH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HR_WFH_Sys_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Sys_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<string>(type: "char(26)", nullable: false),
                    UsersId = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Sys_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Sys_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WH_NhapKhoSerial",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdNhapKhoChiTiet = table.Column<string>(type: "char(26)", nullable: false),
                    Serial = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DaTraLaiNcc = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_NhapKhoSerial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WH_NhapKhoSerial_WH_NhapKhoChiTiet_IdNhapKhoChiTiet",
                        column: x => x.IdNhapKhoChiTiet,
                        principalTable: "WH_NhapKhoChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WH_XuatKhoSerial",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(26)", nullable: false),
                    IdXuatKhoChiTiet = table.Column<string>(type: "char(26)", nullable: false),
                    Serial = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DaTraLai = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WH_XuatKhoSerial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WH_XuatKhoSerial_WH_XuatKhoChiTiet_IdXuatKhoChiTiet",
                        column: x => x.IdXuatKhoChiTiet,
                        principalTable: "WH_XuatKhoChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Name", "NgaySua", "NgayTao", "NguoiSua", "NguoiTao" },
                values: new object[] { 1, "Read", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NgaySua", "NgayTao", "NguoiSua", "NguoiTao" },
                values: new object[] { "01J5WG4BT95GRBZQ70S1G4W0R8", "User", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_HR_WFH_UserId",
                table: "HR_WFH",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesId",
                table: "PermissionRole",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_PURC_HangHoa_IdNhomHang",
                table: "PURC_HangHoa",
                column: "IdNhomHang");

            migrationBuilder.CreateIndex(
                name: "IX_PURC_HinhAnhHangHoa_IdHangHoa",
                table: "PURC_HinhAnhHangHoa",
                column: "IdHangHoa");

            migrationBuilder.CreateIndex(
                name: "IX_PURC_NhomHang_IdNhomHangCha",
                table: "PURC_NhomHang",
                column: "IdNhomHangCha");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_BaoGiaChiTiet_IdBaoGia",
                table: "SALE_BaoGiaChiTiet",
                column: "IdBaoGia");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_BaoGiaComment_IdBaoGia",
                table: "SALE_BaoGiaComment",
                column: "IdBaoGia");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_BaoGiaLyDoTruot_IdBaoGia",
                table: "SALE_BaoGiaLyDoTruot",
                column: "IdBaoGia");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_CongNoSRComment_IdCongNo",
                table: "SALE_CongNoSRComment",
                column: "IdCongNo");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_CTKMChaoKhachHang_IdCTKM",
                table: "SALE_CTKMChaoKhachHang",
                column: "IdCTKM");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_DeNghiThanhToanCMChiTiet_IdDeNghi",
                table: "SALE_DeNghiThanhToanCMChiTiet",
                column: "IdDeNghi");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_DeNghiTraLaiChiTiet_IdDeNghiTraLai",
                table: "SALE_DeNghiTraLaiChiTiet",
                column: "IdDeNghiTraLai");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_KH_KhachHangChaId",
                table: "Sale_KH",
                column: "KhachHangChaId");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_KH_DanhGiaKhachHang_IdKhachHang",
                table: "SALE_KH_DanhGiaKhachHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_KH_KhaiHaiQuan_IdKhachHang",
                table: "SALE_KH_KhaiHaiQuan",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_KH_LienHe_IdKhachHang",
                table: "SALE_KH_LienHe",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_KH_PhanHoiKhachHang_IdKhachHang",
                table: "SALE_KH_PhanHoiKhachHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_SALE_KH_TaiKhoanNganHang_IdKhachHang",
                table: "SALE_KH_TaiKhoanNganHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_User_IdPhongBan",
                table: "Sys_User",
                column: "IdPhongBan");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_User_VanPhongId",
                table: "Sys_User",
                column: "VanPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_WH_ChuyenKhoChiTiet_IdChuyenKho",
                table: "WH_ChuyenKhoChiTiet",
                column: "IdChuyenKho");

            migrationBuilder.CreateIndex(
                name: "IX_WH_NhapKhoChiTiet_IdNhapKho",
                table: "WH_NhapKhoChiTiet",
                column: "IdNhapKho");

            migrationBuilder.CreateIndex(
                name: "IX_WH_NhapKhoSerial_IdNhapKhoChiTiet",
                table: "WH_NhapKhoSerial",
                column: "IdNhapKhoChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_WH_XuatKhoChiTiet_IdXuatKho",
                table: "WH_XuatKhoChiTiet",
                column: "IdXuatKho");

            migrationBuilder.CreateIndex(
                name: "IX_WH_XuatKhoSerial_IdXuatKhoChiTiet",
                table: "WH_XuatKhoSerial",
                column: "IdXuatKhoChiTiet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_CongTacPhiPhuongTien");

            migrationBuilder.DropTable(
                name: "HR_NV_CongTacPhi");

            migrationBuilder.DropTable(
                name: "HR_WFH");

            migrationBuilder.DropTable(
                name: "OutboxMessages");

            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "PURC_HinhAnhHangHoa");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "SALE_BaoGiaChiTiet");

            migrationBuilder.DropTable(
                name: "SALE_BaoGiaComment");

            migrationBuilder.DropTable(
                name: "SALE_BaoGiaLyDoTruot");

            migrationBuilder.DropTable(
                name: "SALE_CongNoSRComment");

            migrationBuilder.DropTable(
                name: "SALE_CongNoSRThucTe");

            migrationBuilder.DropTable(
                name: "SALE_CTKMChaoKhachHang");

            migrationBuilder.DropTable(
                name: "SALE_DeNghiSuaGia");

            migrationBuilder.DropTable(
                name: "SALE_DeNghiThanhToanCMChiTiet");

            migrationBuilder.DropTable(
                name: "SALE_DeNghiTraLaiChiTiet");

            migrationBuilder.DropTable(
                name: "SALE_DuyetXuatTruocHan");

            migrationBuilder.DropTable(
                name: "SALE_KH_DanhGiaKhachHang");

            migrationBuilder.DropTable(
                name: "SALE_KH_EmailNhanHoaDon");

            migrationBuilder.DropTable(
                name: "SALE_KH_HopDong");

            migrationBuilder.DropTable(
                name: "SALE_KH_KhaiHaiQuan");

            migrationBuilder.DropTable(
                name: "SALE_KH_LienHe");

            migrationBuilder.DropTable(
                name: "SALE_KH_Loai");

            migrationBuilder.DropTable(
                name: "SALE_KH_NganhNghe");

            migrationBuilder.DropTable(
                name: "SALE_KH_PhanHoiKhachHang");

            migrationBuilder.DropTable(
                name: "SALE_KH_TaiKhoanNganHang");

            migrationBuilder.DropTable(
                name: "Sys_ChiNhanh");

            migrationBuilder.DropTable(
                name: "Sys_DieuKhoanThanhToan");

            migrationBuilder.DropTable(
                name: "Sys_IPWan");

            migrationBuilder.DropTable(
                name: "WH_ChuyenKhoChiTiet");

            migrationBuilder.DropTable(
                name: "WH_DanhSachKho");

            migrationBuilder.DropTable(
                name: "WH_NhapKhoSerial");

            migrationBuilder.DropTable(
                name: "WH_XuatKhoSerial");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "PURC_HangHoa");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Sys_User");

            migrationBuilder.DropTable(
                name: "SALE_BaoGia");

            migrationBuilder.DropTable(
                name: "SALE_CongNoSR");

            migrationBuilder.DropTable(
                name: "SALE_CTKM");

            migrationBuilder.DropTable(
                name: "SALE_DeNghiThanhToanCM");

            migrationBuilder.DropTable(
                name: "SALE_DeNghiTraLai");

            migrationBuilder.DropTable(
                name: "Sale_KH");

            migrationBuilder.DropTable(
                name: "Wh_ChuyenKho");

            migrationBuilder.DropTable(
                name: "WH_NhapKhoChiTiet");

            migrationBuilder.DropTable(
                name: "WH_XuatKhoChiTiet");

            migrationBuilder.DropTable(
                name: "PURC_NhomHang");

            migrationBuilder.DropTable(
                name: "Sys_PhongBan");

            migrationBuilder.DropTable(
                name: "Sys_VanPhong");

            migrationBuilder.DropTable(
                name: "WH_NhapKho");

            migrationBuilder.DropTable(
                name: "WH_XuatKho");
        }
    }
}
