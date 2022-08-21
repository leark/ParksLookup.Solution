using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class Remove_StateObjFromPark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parks_States_StateId",
                table: "Parks");

            migrationBuilder.DropIndex(
                name: "IX_Parks_StateId",
                table: "Parks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Parks_StateId",
                table: "Parks",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parks_States_StateId",
                table: "Parks",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
