using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace inventory.DataModel.Migrations
{
    public partial class Added_Locations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Possessions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Room = table.Column<int>(nullable: false),
                    TypeOfStorage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Possessions_LocationId",
                table: "Possessions",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Possessions_Locations_LocationId",
                table: "Possessions",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Possessions_Locations_LocationId",
                table: "Possessions");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Possessions_LocationId",
                table: "Possessions");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Possessions");
        }
    }
}
