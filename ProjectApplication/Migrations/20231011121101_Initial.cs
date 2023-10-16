using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectApplication.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectDbs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDbs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskDbs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDbs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDbs_ProjectDbs_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectDbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProjectDbs",
                columns: new[] { "Id", "CreatedDate", "Title" },
                values: new object[] { -1, new DateTime(2023, 10, 11, 14, 11, 1, 835, DateTimeKind.Local).AddTicks(2190), "Learning ASP.NET Core with MVC" });

            migrationBuilder.InsertData(
                table: "TaskDbs",
                columns: new[] { "Id", "Description", "LastUpdated", "ProjectId", "Status" },
                values: new object[,]
                {
                    { -2, "Do it yourself!", new DateTime(2023, 10, 11, 14, 11, 1, 835, DateTimeKind.Local).AddTicks(2419), -1, 0 },
                    { -1, "Follow the turtorials", new DateTime(2023, 10, 11, 14, 11, 1, 835, DateTimeKind.Local).AddTicks(2415), -1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskDbs_ProjectId",
                table: "TaskDbs",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskDbs");

            migrationBuilder.DropTable(
                name: "ProjectDbs");
        }
    }
}
