using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace University.Repository.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Email", "Name", "PersonalNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ketevan@gmail.com", "Ketevan Gomiashvili", "01025879658" },
                    { 2, new DateTime(1998, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ilia@gmail.com", "Ilia Metreveli", "11025879658" },
                    { 3, new DateTime(1991, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "tengiz123@gmail.com", "Tengiz Patchkoria", "21025879658" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Street", "StudentId" },
                values: new object[,]
                {
                    { 1, "Tbilisi", "Test street #22", 1 },
                    { 2, "Tbilisi", "Test street #12", 2 },
                    { 3, "Batumi", "Test street #31", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StudentId",
                table: "Addresses",
                column: "StudentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
