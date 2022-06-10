using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThanksCardAPI.Migrations
{
    public partial class AddUser2Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Users",
                newName: "IsEmployee");

            migrationBuilder.AddColumn<long>(
                name: "Sonzai_Id",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SonzaiId",
                table: "Departments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sonzai_Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SonzaiId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "IsEmployee",
                table: "Users",
                newName: "IsAdmin");
        }
    }
}
