using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Didala.API.Migrations
{
    public partial class moremodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "registerModels",
                columns: table => new
                {
                    RegisterModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    AlternateEmailAddress = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Class = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    FacebookUserName = table.Column<string>(nullable: true),
                    TwitterUserName = table.Column<string>(nullable: true),
                    InstagramUserName = table.Column<string>(nullable: true),
                    GoogleUserName = table.Column<string>(nullable: true),
                    LinkedInUserName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registerModels", x => x.RegisterModelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registerModels");
        }
    }
}
