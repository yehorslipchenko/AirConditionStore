using Microsoft.EntityFrameworkCore.Migrations;

namespace AirConditionStore.DataAccess.Migrations
{
    public partial class MissVariableInAirCondition2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "AirConditions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "AirConditions");
        }
    }
}
