using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADAGroup.EIG.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EIGs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    Vision = table.Column<string>(nullable: true),
                    About = table.Column<string>(nullable: true),
                    Contacts = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EIGs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Hosts = table.Column<string>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_EIGs_GroupId",
                        column: x => x.GroupId,
                        principalTable: "EIGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageAssets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageAssets_EIGs_GroupId",
                        column: x => x.GroupId,
                        principalTable: "EIGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EIGs",
                columns: new[] { "Id", "About", "Contacts", "CreatedBy", "DateCreated", "DateModified", "Logo", "Mission", "ModifiedBy", "Name", "Vision" },
                values: new object[] { new Guid("dce748ad-7c40-420f-bda5-78661e1d253a"), null, null, null, new DateTime(2020, 5, 9, 16, 6, 3, 392, DateTimeKind.Local).AddTicks(9154), new DateTime(2020, 5, 9, 16, 6, 3, 393, DateTimeKind.Local).AddTicks(6632), null, "To make our world a better place", null, "Infor Musiko", "Sample" });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_GroupId",
                table: "Activities",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageAssets_GroupId",
                table: "ImageAssets",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "ImageAssets");

            migrationBuilder.DropTable(
                name: "EIGs");
        }
    }
}
