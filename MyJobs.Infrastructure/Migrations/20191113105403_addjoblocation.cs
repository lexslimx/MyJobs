using Microsoft.EntityFrameworkCore.Migrations;

namespace MyJobs.Infrastructure.Migrations
{
    public partial class addjoblocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Jobs");
        }
    }
}
