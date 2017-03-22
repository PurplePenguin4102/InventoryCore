using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace inventory.DataModel.Migrations
{
    public partial class initsqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Possessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Acquired = table.Column<DateTime>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    InUse = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: true),
                    PartOfId = table.Column<int>(nullable: true),
                    SubCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Possessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Possessions_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Possessions_Possessions_PartOfId",
                        column: x => x.PartOfId,
                        principalTable: "Possessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Possessions_OwnerId",
                table: "Possessions",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Possessions_PartOfId",
                table: "Possessions",
                column: "PartOfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Possessions");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
