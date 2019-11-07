using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174_TestCoreApp.Migrations.Log
{
    public partial class Log : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(nullable: false),
                    HttpStatusCode = table.Column<int>(nullable: false),
                    TimeOfLog = table.Column<DateTime>(nullable: false),
                    Request = table.Column<string>(nullable: true),
                    Response = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.RequestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log");
        }
    }
}
