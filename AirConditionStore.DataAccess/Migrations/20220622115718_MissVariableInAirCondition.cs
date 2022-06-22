using Microsoft.EntityFrameworkCore.Migrations;

namespace AirConditionStore.DataAccess.Migrations
{
    public partial class MissVariableInAirCondition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AirConditions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AirConditions");
        }
    }
}
