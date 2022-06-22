using Microsoft.EntityFrameworkCore.Migrations;

namespace AirConditionStore.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirConditionsTemperatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinValueOfRange = table.Column<int>(type: "int", nullable: false),
                    MaxValueOfRange = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditionsTemperatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirConditionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compressors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompressorType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compressors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstallationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstallationType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomArea = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    AirConditionTypeId = table.Column<int>(type: "int", nullable: false),
                    OperationNegativeId = table.Column<int>(type: "int", nullable: false),
                    IndoorUnitInstallationTypeId = table.Column<int>(type: "int", nullable: false),
                    BrandId1 = table.Column<int>(type: "int", nullable: true),
                    CompressorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirConditions_AirConditionsTemperatures_OperationNegativeId",
                        column: x => x.OperationNegativeId,
                        principalTable: "AirConditionsTemperatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirConditions_AirConditionTypes_AirConditionTypeId",
                        column: x => x.AirConditionTypeId,
                        principalTable: "AirConditionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirConditions_Brand_BrandId1",
                        column: x => x.BrandId1,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirConditions_Compressors_CompressorId",
                        column: x => x.CompressorId,
                        principalTable: "Compressors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AirConditions_InstallationTypes_IndoorUnitInstallationTypeId",
                        column: x => x.IndoorUnitInstallationTypeId,
                        principalTable: "InstallationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirConditions_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersInformation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Capabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capabilities_AirConditions_AirConditionId",
                        column: x => x.AirConditionId,
                        principalTable: "AirConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Control = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlTypes_AirConditions_AirConditionId",
                        column: x => x.AirConditionId,
                        principalTable: "AirConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_AirConditions_AirConditionId",
                        column: x => x.AirConditionId,
                        principalTable: "AirConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperatingModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingModes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingModes_AirConditions_AirConditionId",
                        column: x => x.AirConditionId,
                        principalTable: "AirConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AirConditionId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AirConditions_AirConditionId",
                        column: x => x.AirConditionId,
                        principalTable: "AirConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirConditions_AirConditionTypeId",
                table: "AirConditions",
                column: "AirConditionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AirConditions_BrandId1",
                table: "AirConditions",
                column: "BrandId1");

            migrationBuilder.CreateIndex(
                name: "IX_AirConditions_CompressorId",
                table: "AirConditions",
                column: "CompressorId");

            migrationBuilder.CreateIndex(
                name: "IX_AirConditions_IndoorUnitInstallationTypeId",
                table: "AirConditions",
                column: "IndoorUnitInstallationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AirConditions_OperationNegativeId",
                table: "AirConditions",
                column: "OperationNegativeId");

            migrationBuilder.CreateIndex(
                name: "IX_AirConditions_StatusId",
                table: "AirConditions",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Capabilities_AirConditionId",
                table: "Capabilities",
                column: "AirConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlTypes_AirConditionId",
                table: "ControlTypes",
                column: "AirConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_AirConditionId",
                table: "Countries",
                column: "AirConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingModes_AirConditionId",
                table: "OperatingModes",
                column: "AirConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AirConditionId",
                table: "Orders",
                column: "AirConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersInformation_UserId",
                table: "UsersInformation",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Capabilities");

            migrationBuilder.DropTable(
                name: "ControlTypes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "OperatingModes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "UsersInformation");

            migrationBuilder.DropTable(
                name: "AirConditions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AirConditionsTemperatures");

            migrationBuilder.DropTable(
                name: "AirConditionTypes");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Compressors");

            migrationBuilder.DropTable(
                name: "InstallationTypes");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
