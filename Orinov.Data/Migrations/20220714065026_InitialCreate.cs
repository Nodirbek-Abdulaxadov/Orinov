using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Orinov.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    TitleEn = table.Column<string>(type: "text", nullable: false),
                    TitleUz = table.Column<string>(type: "text", nullable: false),
                    TitleRu = table.Column<string>(type: "text", nullable: false),
                    PlaceEn = table.Column<string>(type: "text", nullable: false),
                    PlaceUz = table.Column<string>(type: "text", nullable: false),
                    PlaceRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cvmodels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cvmodels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalBackgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartYear = table.Column<int>(type: "integer", nullable: false),
                    EndYear = table.Column<int>(type: "integer", nullable: false),
                    DegreeEn = table.Column<string>(type: "text", nullable: false),
                    DegreeUz = table.Column<string>(type: "text", nullable: false),
                    DegreeRu = table.Column<string>(type: "text", nullable: false),
                    FieldOfResearchEn = table.Column<string>(type: "text", nullable: false),
                    FieldOfResearchUz = table.Column<string>(type: "text", nullable: false),
                    FieldOfResearchRu = table.Column<string>(type: "text", nullable: false),
                    ThesisEn = table.Column<string>(type: "text", nullable: false),
                    ThesisUz = table.Column<string>(type: "text", nullable: false),
                    ThesisRu = table.Column<string>(type: "text", nullable: false),
                    SupervisorEn = table.Column<string>(type: "text", nullable: false),
                    SupervisorUz = table.Column<string>(type: "text", nullable: false),
                    SupervisorRu = table.Column<string>(type: "text", nullable: false),
                    CVModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalBackgrounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartYear = table.Column<int>(type: "integer", nullable: false),
                    EndYear = table.Column<int>(type: "integer", nullable: false),
                    PositionUz = table.Column<string>(type: "text", nullable: false),
                    PositionEn = table.Column<string>(type: "text", nullable: false),
                    PositionRu = table.Column<string>(type: "text", nullable: false),
                    CompanyEn = table.Column<string>(type: "text", nullable: false),
                    CompanyUz = table.Column<string>(type: "text", nullable: false),
                    CompanyRu = table.Column<string>(type: "text", nullable: false),
                    CVModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    SpeakerEn = table.Column<string>(type: "text", nullable: true),
                    SpeakerUz = table.Column<string>(type: "text", nullable: true),
                    SpeakerRu = table.Column<string>(type: "text", nullable: true),
                    TitleEn = table.Column<string>(type: "text", nullable: false),
                    TitleUz = table.Column<string>(type: "text", nullable: false),
                    TitleRu = table.Column<string>(type: "text", nullable: false),
                    PlaceEn = table.Column<string>(type: "text", nullable: false),
                    PlaceUz = table.Column<string>(type: "text", nullable: false),
                    PlaceRu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    DegreeEn = table.Column<string>(type: "text", nullable: false),
                    DegreeUz = table.Column<string>(type: "text", nullable: false),
                    DegreeRu = table.Column<string>(type: "text", nullable: false),
                    CommentEn = table.Column<string>(type: "text", nullable: true),
                    CommentUz = table.Column<string>(type: "text", nullable: true),
                    CommentRu = table.Column<string>(type: "text", nullable: true),
                    CVModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateOfBirthEn = table.Column<string>(type: "text", nullable: false),
                    DateOfBirthUz = table.Column<string>(type: "text", nullable: false),
                    DateOfBirthRu = table.Column<string>(type: "text", nullable: false),
                    GenderEn = table.Column<string>(type: "text", nullable: false),
                    GenderUz = table.Column<string>(type: "text", nullable: false),
                    GenderRu = table.Column<string>(type: "text", nullable: false),
                    NationalityEn = table.Column<string>(type: "text", nullable: false),
                    NationalityUz = table.Column<string>(type: "text", nullable: false),
                    NationalityRu = table.Column<string>(type: "text", nullable: false),
                    AddressEn = table.Column<string>(type: "text", nullable: false),
                    AddressUz = table.Column<string>(type: "text", nullable: false),
                    AddressRu = table.Column<string>(type: "text", nullable: false),
                    Mobile = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CVModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublishedYear = table.Column<int>(type: "integer", nullable: false),
                    AuthorsEn = table.Column<string>(type: "text", nullable: false),
                    AuthorsUz = table.Column<string>(type: "text", nullable: false),
                    AuthorsRu = table.Column<string>(type: "text", nullable: false),
                    ThemeEn = table.Column<string>(type: "text", nullable: false),
                    ThemeUz = table.Column<string>(type: "text", nullable: false),
                    ThemeRu = table.Column<string>(type: "text", nullable: false),
                    AdditionalEn = table.Column<string>(type: "text", nullable: false),
                    AdditionalUz = table.Column<string>(type: "text", nullable: false),
                    AdditionalRu = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false),
                    IsBook = table.Column<bool>(type: "boolean", nullable: false),
                    CVModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchInterests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: false),
                    NameRu = table.Column<string>(type: "text", nullable: false),
                    TitleEn = table.Column<string>(type: "text", nullable: false),
                    TitleUz = table.Column<string>(type: "text", nullable: false),
                    TitleRu = table.Column<string>(type: "text", nullable: false),
                    CVModelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchInterests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilePath = table.Column<int>(type: "integer", nullable: false),
                    EventsId = table.Column<int>(type: "integer", nullable: true),
                    PublicationsId = table.Column<int>(type: "integer", nullable: true),
                    EventId = table.Column<int>(type: "integer", nullable: true),
                    PublicationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileModels_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileModels_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileModels_EventId",
                table: "FileModels",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_FileModels_PublicationId",
                table: "FileModels",
                column: "PublicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Cvmodels");

            migrationBuilder.DropTable(
                name: "EducationalBackgrounds");

            migrationBuilder.DropTable(
                name: "Employments");

            migrationBuilder.DropTable(
                name: "FileModels");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "PersonalInformations");

            migrationBuilder.DropTable(
                name: "ResearchInterests");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Publications");
        }
    }
}
