using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBongDaSo.Migrations
{
    public partial class udpateentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NguoiDungTaiKhoan",
                table: "BaiViets",
                type: "nvarchar(40)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanNguoiDang",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenTacGia",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LoaiNguoiDung",
                columns: table => new
                {
                    LoaiNguoiDungId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNguoiDung", x => x.LoaiNguoiDungId);
                });

            migrationBuilder.CreateTable(
                name: "QuyenHan",
                columns: table => new
                {
                    QuyenHanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyenHan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyenHan", x => x.QuyenHanId);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    TaiKhoan = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianThamGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoaiNguoiDungId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.TaiKhoan);
                    table.ForeignKey(
                        name: "FK_NguoiDung_LoaiNguoiDung_LoaiNguoiDungId",
                        column: x => x.LoaiNguoiDungId,
                        principalTable: "LoaiNguoiDung",
                        principalColumn: "LoaiNguoiDungId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuyenHan_LoaiNguoiDung",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuyenHanId = table.Column<int>(type: "int", nullable: false),
                    LoaiNguoiDungId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyenHan_LoaiNguoiDung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuyenHan_LoaiNguoiDung_LoaiNguoiDung_LoaiNguoiDungId",
                        column: x => x.LoaiNguoiDungId,
                        principalTable: "LoaiNguoiDung",
                        principalColumn: "LoaiNguoiDungId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuyenHan_LoaiNguoiDung_QuyenHan_QuyenHanId",
                        column: x => x.QuyenHanId,
                        principalTable: "QuyenHan",
                        principalColumn: "QuyenHanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaiViets_NguoiDungTaiKhoan",
                table: "BaiViets",
                column: "NguoiDungTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_LoaiNguoiDungId",
                table: "NguoiDung",
                column: "LoaiNguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_QuyenHan_LoaiNguoiDung_LoaiNguoiDungId",
                table: "QuyenHan_LoaiNguoiDung",
                column: "LoaiNguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_QuyenHan_LoaiNguoiDung_QuyenHanId",
                table: "QuyenHan_LoaiNguoiDung",
                column: "QuyenHanId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiViets_NguoiDung_NguoiDungTaiKhoan",
                table: "BaiViets",
                column: "NguoiDungTaiKhoan",
                principalTable: "NguoiDung",
                principalColumn: "TaiKhoan",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaiViets_NguoiDung_NguoiDungTaiKhoan",
                table: "BaiViets");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "QuyenHan_LoaiNguoiDung");

            migrationBuilder.DropTable(
                name: "LoaiNguoiDung");

            migrationBuilder.DropTable(
                name: "QuyenHan");

            migrationBuilder.DropIndex(
                name: "IX_BaiViets_NguoiDungTaiKhoan",
                table: "BaiViets");

            migrationBuilder.DropColumn(
                name: "NguoiDungTaiKhoan",
                table: "BaiViets");

            migrationBuilder.DropColumn(
                name: "TaiKhoanNguoiDang",
                table: "BaiViets");

            migrationBuilder.DropColumn(
                name: "TenTacGia",
                table: "BaiViets");
        }
    }
}
