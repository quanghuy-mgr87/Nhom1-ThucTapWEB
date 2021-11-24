using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBongDaSo.Migrations
{
    public partial class udpateentities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaiViets_NguoiDung_NguoiDungTaiKhoan",
                table: "BaiViets");

            migrationBuilder.DropForeignKey(
                name: "FK_NguoiDung_LoaiNguoiDung_LoaiNguoiDungId",
                table: "NguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDung_LoaiNguoiDung_LoaiNguoiDungId",
                table: "QuyenHan_LoaiNguoiDung");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDung_QuyenHan_QuyenHanId",
                table: "QuyenHan_LoaiNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenHan_LoaiNguoiDung",
                table: "QuyenHan_LoaiNguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenHan",
                table: "QuyenHan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiNguoiDung",
                table: "LoaiNguoiDung");

            migrationBuilder.RenameTable(
                name: "QuyenHan_LoaiNguoiDung",
                newName: "QuyenHan_LoaiNguoiDungs");

            migrationBuilder.RenameTable(
                name: "QuyenHan",
                newName: "QuyenHans");

            migrationBuilder.RenameTable(
                name: "NguoiDung",
                newName: "NguoiDungs");

            migrationBuilder.RenameTable(
                name: "LoaiNguoiDung",
                newName: "LoaiNguoiDungs");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenHan_LoaiNguoiDung_QuyenHanId",
                table: "QuyenHan_LoaiNguoiDungs",
                newName: "IX_QuyenHan_LoaiNguoiDungs_QuyenHanId");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenHan_LoaiNguoiDung_LoaiNguoiDungId",
                table: "QuyenHan_LoaiNguoiDungs",
                newName: "IX_QuyenHan_LoaiNguoiDungs_LoaiNguoiDungId");

            migrationBuilder.RenameIndex(
                name: "IX_NguoiDung_LoaiNguoiDungId",
                table: "NguoiDungs",
                newName: "IX_NguoiDungs_LoaiNguoiDungId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenHan_LoaiNguoiDungs",
                table: "QuyenHan_LoaiNguoiDungs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenHans",
                table: "QuyenHans",
                column: "QuyenHanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDungs",
                table: "NguoiDungs",
                column: "TaiKhoan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiNguoiDungs",
                table: "LoaiNguoiDungs",
                column: "LoaiNguoiDungId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiViets_NguoiDungs_NguoiDungTaiKhoan",
                table: "BaiViets",
                column: "NguoiDungTaiKhoan",
                principalTable: "NguoiDungs",
                principalColumn: "TaiKhoan",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NguoiDungs_LoaiNguoiDungs_LoaiNguoiDungId",
                table: "NguoiDungs",
                column: "LoaiNguoiDungId",
                principalTable: "LoaiNguoiDungs",
                principalColumn: "LoaiNguoiDungId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDungs_LoaiNguoiDungs_LoaiNguoiDungId",
                table: "QuyenHan_LoaiNguoiDungs",
                column: "LoaiNguoiDungId",
                principalTable: "LoaiNguoiDungs",
                principalColumn: "LoaiNguoiDungId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDungs_QuyenHans_QuyenHanId",
                table: "QuyenHan_LoaiNguoiDungs",
                column: "QuyenHanId",
                principalTable: "QuyenHans",
                principalColumn: "QuyenHanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaiViets_NguoiDungs_NguoiDungTaiKhoan",
                table: "BaiViets");

            migrationBuilder.DropForeignKey(
                name: "FK_NguoiDungs_LoaiNguoiDungs_LoaiNguoiDungId",
                table: "NguoiDungs");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDungs_LoaiNguoiDungs_LoaiNguoiDungId",
                table: "QuyenHan_LoaiNguoiDungs");

            migrationBuilder.DropForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDungs_QuyenHans_QuyenHanId",
                table: "QuyenHan_LoaiNguoiDungs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenHans",
                table: "QuyenHans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuyenHan_LoaiNguoiDungs",
                table: "QuyenHan_LoaiNguoiDungs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NguoiDungs",
                table: "NguoiDungs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiNguoiDungs",
                table: "LoaiNguoiDungs");

            migrationBuilder.RenameTable(
                name: "QuyenHans",
                newName: "QuyenHan");

            migrationBuilder.RenameTable(
                name: "QuyenHan_LoaiNguoiDungs",
                newName: "QuyenHan_LoaiNguoiDung");

            migrationBuilder.RenameTable(
                name: "NguoiDungs",
                newName: "NguoiDung");

            migrationBuilder.RenameTable(
                name: "LoaiNguoiDungs",
                newName: "LoaiNguoiDung");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenHan_LoaiNguoiDungs_QuyenHanId",
                table: "QuyenHan_LoaiNguoiDung",
                newName: "IX_QuyenHan_LoaiNguoiDung_QuyenHanId");

            migrationBuilder.RenameIndex(
                name: "IX_QuyenHan_LoaiNguoiDungs_LoaiNguoiDungId",
                table: "QuyenHan_LoaiNguoiDung",
                newName: "IX_QuyenHan_LoaiNguoiDung_LoaiNguoiDungId");

            migrationBuilder.RenameIndex(
                name: "IX_NguoiDungs_LoaiNguoiDungId",
                table: "NguoiDung",
                newName: "IX_NguoiDung_LoaiNguoiDungId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenHan",
                table: "QuyenHan",
                column: "QuyenHanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuyenHan_LoaiNguoiDung",
                table: "QuyenHan_LoaiNguoiDung",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung",
                column: "TaiKhoan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiNguoiDung",
                table: "LoaiNguoiDung",
                column: "LoaiNguoiDungId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiViets_NguoiDung_NguoiDungTaiKhoan",
                table: "BaiViets",
                column: "NguoiDungTaiKhoan",
                principalTable: "NguoiDung",
                principalColumn: "TaiKhoan",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NguoiDung_LoaiNguoiDung_LoaiNguoiDungId",
                table: "NguoiDung",
                column: "LoaiNguoiDungId",
                principalTable: "LoaiNguoiDung",
                principalColumn: "LoaiNguoiDungId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDung_LoaiNguoiDung_LoaiNguoiDungId",
                table: "QuyenHan_LoaiNguoiDung",
                column: "LoaiNguoiDungId",
                principalTable: "LoaiNguoiDung",
                principalColumn: "LoaiNguoiDungId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuyenHan_LoaiNguoiDung_QuyenHan_QuyenHanId",
                table: "QuyenHan_LoaiNguoiDung",
                column: "QuyenHanId",
                principalTable: "QuyenHan",
                principalColumn: "QuyenHanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
