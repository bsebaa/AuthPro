using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthPro.Migrations
{
    public partial class ExtendIGG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentLocation",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IGG",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentLocation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IGG",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "AspNetUsers");
        }
    }
}
