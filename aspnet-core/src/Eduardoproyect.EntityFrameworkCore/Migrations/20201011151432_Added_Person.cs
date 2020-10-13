using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduardoproyect.Migrations
{
    public partial class Added_Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpMovies");

            migrationBuilder.CreateTable(
                name: "AbpPersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Productor = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    succefull = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPersons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpPersons");

            migrationBuilder.CreateTable(
                name: "AbpMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Productor = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Year = table.Column<long>(type: "bigint", nullable: true),
                    succefull = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpMovies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpMovies_CreatorUserId",
                table: "AbpMovies",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpMovies_DeleterUserId",
                table: "AbpMovies",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpMovies_LastModifierUserId",
                table: "AbpMovies",
                column: "LastModifierUserId");
        }
    }
}
