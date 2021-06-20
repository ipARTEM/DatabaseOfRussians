using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBOfRussians.Services.Migrations
{
    public partial class InitDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surnames = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    SNILS = table.Column<long>(nullable: false),
                    INN = table.Column<long>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DateOfDeath = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}
