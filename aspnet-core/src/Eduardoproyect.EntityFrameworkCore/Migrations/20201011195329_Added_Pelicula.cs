using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduardoproyect.Migrations
{
    public partial class Added_Pelicula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AbpPersons");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "AbpPersons");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AbpPersons");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "AbpPersons");

            migrationBuilder.CreateTable(
                name: "AbpPeliculas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    director = table.Column<string>(nullable: true),
                    productor = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    successfull = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPeliculas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpPeliculas");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AbpPersons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "AbpPersons",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AbpPersons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "AbpPersons",
                type: "bigint",
                nullable: true);
        }
    }
}
