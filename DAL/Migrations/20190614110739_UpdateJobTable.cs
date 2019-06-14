using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UpdateJobTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Persons_PersonsPersonId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PersonsPersonId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PersonsPersonId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Fk_PersonId",
                table: "Jobs",
                newName: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PersonId",
                table: "Jobs",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Persons_PersonId",
                table: "Jobs",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Persons_PersonId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PersonId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Jobs",
                newName: "Fk_PersonId");

            migrationBuilder.AddColumn<int>(
                name: "PersonsPersonId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PersonsPersonId",
                table: "Jobs",
                column: "PersonsPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Persons_PersonsPersonId",
                table: "Jobs",
                column: "PersonsPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
