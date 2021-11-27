using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBongDaSo.Migrations
{
    public partial class updateloainguoidung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaLoai",
                table: "LoaiNguoiDungs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaLoai",
                table: "LoaiNguoiDungs");
        }
    }
}
