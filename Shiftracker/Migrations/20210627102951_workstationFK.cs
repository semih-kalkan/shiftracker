using Microsoft.EntityFrameworkCore.Migrations;

namespace ShifTracker.Migrations
{
    public partial class workstationFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkstationId",
                table: "Shifts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_WorkstationId",
                table: "Shifts",
                column: "WorkstationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shifts_Workstations_WorkstationId",
                table: "Shifts",
                column: "WorkstationId",
                principalTable: "Workstations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shifts_Workstations_WorkstationId",
                table: "Shifts");

            migrationBuilder.DropIndex(
                name: "IX_Shifts_WorkstationId",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "WorkstationId",
                table: "Shifts");
        }
    }
}
