﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MyJobs.Infrastructure.Migrations
{
    public partial class adddistancetojobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Distance",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Jobs");
        }
    }
}
