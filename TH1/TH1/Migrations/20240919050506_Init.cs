using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TH1.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    MaAdmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenAdmin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChiAdmin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DienThoaiAdmin = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TenDNAdmin = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MatKhauAdmin = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NgaySinhAdmin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinhAdmin = table.Column<bool>(type: "bit", nullable: false),
                    EmailAdmin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuyenAdmin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.MaAdmin);
                });

            migrationBuilder.CreateTable(
                name: "ChuDes",
                columns: table => new
                {
                    MaCD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuDe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuDes", x => x.MaCD);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChiKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DienThoaiKH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TenDN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DaDuyet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "NhaXuatBans",
                columns: table => new
                {
                    MaNXB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNXB = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBans", x => x.MaNXB);
                });

            migrationBuilder.CreateTable(
                name: "QuangCaos",
                columns: table => new
                {
                    STT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    HinhMinhHoa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Href = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuangCaos", x => x.STT);
                });

            migrationBuilder.CreateTable(
                name: "TacGias",
                columns: table => new
                {
                    MaTG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChiTG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DienThoaiTG = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGias", x => x.MaTG);
                });

            migrationBuilder.CreateTable(
                name: "ThamDos",
                columns: table => new
                {
                    MaCH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoiDungThamDo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TongSoBinhChon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThamDos", x => x.MaCH);
                });

            migrationBuilder.CreateTable(
                name: "DonDatHangs",
                columns: table => new
                {
                    SoDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    NgayDH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TriGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaGiao = table.Column<bool>(type: "bit", nullable: false),
                    NgayGiaoHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DienThoaiNhan = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    HTThanhToan = table.Column<bool>(type: "bit", nullable: false),
                    HTGiaoHang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDatHangs", x => x.SoDH);
                    table.ForeignKey(
                        name: "FK_DonDatHangs_KhachHangs_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saches",
                columns: table => new
                {
                    MaSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhMinhHoa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaCD = table.Column<int>(type: "int", nullable: true),
                    MaNXB = table.Column<int>(type: "int", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoLuongBan = table.Column<int>(type: "int", nullable: false),
                    SoLanXem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saches", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Saches_ChuDes_MaCD",
                        column: x => x.MaCD,
                        principalTable: "ChuDes",
                        principalColumn: "MaCD");
                    table.ForeignKey(
                        name: "FK_Saches_NhaXuatBans_MaNXB",
                        column: x => x.MaNXB,
                        principalTable: "NhaXuatBans",
                        principalColumn: "MaNXB");
                });

            migrationBuilder.CreateTable(
                name: "CTThamDos",
                columns: table => new
                {
                    MaCH = table.Column<int>(type: "int", nullable: false),
                    STT = table.Column<int>(type: "int", nullable: false),
                    NoiDungTraLoi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SoLanBinhChon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTThamDos", x => x.MaCH);
                    table.ForeignKey(
                        name: "FK_CTThamDos_ThamDos_MaCH",
                        column: x => x.MaCH,
                        principalTable: "ThamDos",
                        principalColumn: "MaCH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VietSaches",
                columns: table => new
                {
                    MaTG = table.Column<int>(type: "int", nullable: false),
                    MaSach = table.Column<int>(type: "int", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VietSaches", x => x.MaTG);
                    table.ForeignKey(
                        name: "FK_VietSaches_Saches_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Saches",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VietSaches_TacGias_MaTG",
                        column: x => x.MaTG,
                        principalTable: "TacGias",
                        principalColumn: "MaTG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonDatHangs_MaKH",
                table: "DonDatHangs",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_MaCD",
                table: "Saches",
                column: "MaCD");

            migrationBuilder.CreateIndex(
                name: "IX_Saches_MaNXB",
                table: "Saches",
                column: "MaNXB");

            migrationBuilder.CreateIndex(
                name: "IX_VietSaches_MaSach",
                table: "VietSaches",
                column: "MaSach");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CTThamDos");

            migrationBuilder.DropTable(
                name: "DonDatHangs");

            migrationBuilder.DropTable(
                name: "QuangCaos");

            migrationBuilder.DropTable(
                name: "VietSaches");

            migrationBuilder.DropTable(
                name: "ThamDos");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Saches");

            migrationBuilder.DropTable(
                name: "TacGias");

            migrationBuilder.DropTable(
                name: "ChuDes");

            migrationBuilder.DropTable(
                name: "NhaXuatBans");
        }
    }
}
