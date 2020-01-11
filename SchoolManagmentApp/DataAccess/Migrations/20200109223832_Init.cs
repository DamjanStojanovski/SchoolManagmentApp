using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SchoolFullName = table.Column<string>(maxLength: 100, nullable: false),
                    SchoolShortName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    WebsiteURL = table.Column<string>(maxLength: 100, nullable: false),
                    VATNumber = table.Column<string>(nullable: false),
                    MuncipalityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Municipalities_MuncipalityId",
                        column: x => x.MuncipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schools_MuncipalityId",
                table: "Schools",
                column: "MuncipalityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Municipalities");
        }
    }
}
