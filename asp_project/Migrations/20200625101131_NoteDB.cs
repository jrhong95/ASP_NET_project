using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class NoteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Found",
                columns: table => new
                {
                    Found_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Found_data = table.Column<string>(nullable: true),
                    Found_DateTime = table.Column<DateTime>(nullable: false),
                    Found_BigCate = table.Column<string>(nullable: true),
                    Found_SmallCate = table.Column<string>(nullable: true),
                    Found_Name = table.Column<string>(nullable: true),
                    Found_GetPosition = table.Column<string>(nullable: true),
                    Found_ImageURL = table.Column<string>(nullable: true),
                    Found_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Found", x => x.Found_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Found");
        }
    }
}
