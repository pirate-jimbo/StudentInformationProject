using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentInformationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedStudentAndClassTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 1" },
                    { 2, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 2" },
                    { 3, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 3" },
                    { 4, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 4" },
                    { 5, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 5" },
                    { 6, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 6" },
                    { 7, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 7" },
                    { 8, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 8" },
                    { 9, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 9" },
                    { 10, new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 6, 3, 1, 59, 26, 87, DateTimeKind.Local).AddTicks(4018), "Class 10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
