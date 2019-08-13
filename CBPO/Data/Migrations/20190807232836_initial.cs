using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CBPO.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Checklists",
                columns: table => new
                {
                    BikeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SerialNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    BikePicture = table.Column<string>(nullable: true),
                    LockCombination = table.Column<int>(nullable: false),
                    CleanInspectForCracks = table.Column<string>(nullable: true),
                    GreaseSeatpost = table.Column<string>(nullable: true),
                    InspectForCracksBends = table.Column<string>(nullable: true),
                    RepackHeadset = table.Column<string>(nullable: true),
                    GreaseStem = table.Column<string>(nullable: true),
                    RepackBottomBracket = table.Column<string>(nullable: true),
                    GreasePedalThreads = table.Column<string>(nullable: true),
                    CableAdjustFrontDer = table.Column<string>(nullable: true),
                    CableAdjustRearDer = table.Column<string>(nullable: true),
                    CheckChainStretch = table.Column<string>(nullable: true),
                    CleanOilChain = table.Column<string>(nullable: true),
                    CableAdjustFrontBrake = table.Column<string>(nullable: true),
                    CableAdjustRearBrake = table.Column<string>(nullable: true),
                    RepackFrontHub = table.Column<string>(nullable: true),
                    TrueFrontWheel = table.Column<string>(nullable: true),
                    RepackRearHub = table.Column<string>(nullable: true),
                    TrueRearWheel = table.Column<string>(nullable: true),
                    InflateTires = table.Column<string>(nullable: true),
                    TiresHoldingAir = table.Column<string>(nullable: true),
                    AccurateShifting = table.Column<string>(nullable: true),
                    GoodBraking = table.Column<string>(nullable: true),
                    RidingClassCompleted = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    CompleteDate = table.Column<DateTime>(nullable: false),
                    NumOfDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklists", x => x.BikeID);
                });

            migrationBuilder.CreateTable(
                name: "Demographics",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId1 = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Youth = table.Column<bool>(nullable: false),
                    School = table.Column<string>(nullable: true),
                    ParentGuardianEmail = table.Column<string>(nullable: true),
                    ParentGuardianPhone = table.Column<string>(nullable: true),
                    ReducedLunch = table.Column<string>(nullable: true),
                    Consent = table.Column<bool>(nullable: false),
                    Income = table.Column<int>(nullable: false),
                    Employer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demographics", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Demographics_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demographics_UserId1",
                table: "Demographics",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checklists");

            migrationBuilder.DropTable(
                name: "Demographics");
        }
    }
}
