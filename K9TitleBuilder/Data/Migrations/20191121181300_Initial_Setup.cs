using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace K9TitleBuilder.Data.Migrations
{
    public partial class Initial_Setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ribbon",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ribbon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StreetAddr1 = table.Column<string>(nullable: true),
                    StreetAddr2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Lat = table.Column<float>(nullable: false),
                    Long = table.Column<float>(nullable: false),
                    MapUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShowEvent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    VenueID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowEvent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShowEvent_Venue_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Run",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Score = table.Column<float>(nullable: false),
                    Ring = table.Column<string>(nullable: true),
                    ArmBand = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ClassLevel = table.Column<int>(nullable: false),
                    ExperienceLevel = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    RingTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    RunTime = table.Column<TimeSpan>(nullable: false),
                    Judge = table.Column<string>(nullable: true),
                    Handler = table.Column<string>(nullable: true),
                    ClassPlacing = table.Column<int>(nullable: false),
                    Qualifying = table.Column<bool>(nullable: false),
                    ShowEventID = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Run", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Run_ShowEvent_ShowEventID",
                        column: x => x.ShowEventID,
                        principalTable: "ShowEvent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MediaItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    DogID = table.Column<int>(nullable: true),
                    PersonID = table.Column<int>(nullable: true),
                    RibbonID = table.Column<int>(nullable: true),
                    RunID = table.Column<int>(nullable: true),
                    ShowEventID = table.Column<int>(nullable: true),
                    VenueID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MediaItem_Ribbon_RibbonID",
                        column: x => x.RibbonID,
                        principalTable: "Ribbon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaItem_Run_RunID",
                        column: x => x.RunID,
                        principalTable: "Run",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaItem_ShowEvent_ShowEventID",
                        column: x => x.ShowEventID,
                        principalTable: "ShowEvent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaItem_Venue_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Addr1 = table.Column<string>(nullable: true),
                    Addr2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    DogID = table.Column<int>(nullable: true),
                    KennelName = table.Column<string>(nullable: true),
                    LocationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Person_Venue_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Venue",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    RegName = table.Column<string>(nullable: true),
                    CallName = table.Column<string>(nullable: true),
                    BreederID = table.Column<int>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Coat = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Height = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    Pedigree = table.Column<string>(nullable: true),
                    SireId = table.Column<int>(nullable: true),
                    DamId = table.Column<int>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Altered = table.Column<bool>(nullable: false),
                    AKCReg = table.Column<string>(nullable: true),
                    CKCReg = table.Column<string>(nullable: true),
                    UKCReg = table.Column<string>(nullable: true),
                    RallyJumpHeight = table.Column<float>(nullable: false),
                    ObedienceJumpHeight = table.Column<float>(nullable: false),
                    AgilityJumpHeight = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dog_Person_BreederID",
                        column: x => x.BreederID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dog_Dog_DamId",
                        column: x => x.DamId,
                        principalTable: "Dog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dog_Dog_SireId",
                        column: x => x.SireId,
                        principalTable: "Dog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true),
                    Postfix = table.Column<bool>(nullable: false),
                    DogID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Title_Dog_DogID",
                        column: x => x.DogID,
                        principalTable: "Dog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Leg",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edition = table.Column<long>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TitleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Leg_Title_TitleID",
                        column: x => x.TitleID,
                        principalTable: "Title",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dog_BreederID",
                table: "Dog",
                column: "BreederID");

            migrationBuilder.CreateIndex(
                name: "IX_Dog_DamId",
                table: "Dog",
                column: "DamId");

            migrationBuilder.CreateIndex(
                name: "IX_Dog_SireId",
                table: "Dog",
                column: "SireId");

            migrationBuilder.CreateIndex(
                name: "IX_Leg_TitleID",
                table: "Leg",
                column: "TitleID");

            migrationBuilder.CreateIndex(
                name: "IX_MediaItem_DogID",
                table: "MediaItem",
                column: "DogID");

            migrationBuilder.CreateIndex(
                name: "IX_MediaItem_PersonID",
                table: "MediaItem",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_MediaItem_RibbonID",
                table: "MediaItem",
                column: "RibbonID");

            migrationBuilder.CreateIndex(
                name: "IX_MediaItem_RunID",
                table: "MediaItem",
                column: "RunID");

            migrationBuilder.CreateIndex(
                name: "IX_MediaItem_ShowEventID",
                table: "MediaItem",
                column: "ShowEventID");

            migrationBuilder.CreateIndex(
                name: "IX_MediaItem_VenueID",
                table: "MediaItem",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_LocationID",
                table: "Person",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DogID",
                table: "Person",
                column: "DogID");

            migrationBuilder.CreateIndex(
                name: "IX_Run_ShowEventID",
                table: "Run",
                column: "ShowEventID");

            migrationBuilder.CreateIndex(
                name: "IX_ShowEvent_VenueID",
                table: "ShowEvent",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_Title_DogID",
                table: "Title",
                column: "DogID");

            migrationBuilder.AddForeignKey(
                name: "FK_MediaItem_Person_PersonID",
                table: "MediaItem",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaItem_Dog_DogID",
                table: "MediaItem",
                column: "DogID",
                principalTable: "Dog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Dog_DogID",
                table: "Person",
                column: "DogID",
                principalTable: "Dog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Person_BreederID",
                table: "Dog");

            migrationBuilder.DropTable(
                name: "Leg");

            migrationBuilder.DropTable(
                name: "MediaItem");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Ribbon");

            migrationBuilder.DropTable(
                name: "Run");

            migrationBuilder.DropTable(
                name: "ShowEvent");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Venue");

            migrationBuilder.DropTable(
                name: "Dog");
        }
    }
}
