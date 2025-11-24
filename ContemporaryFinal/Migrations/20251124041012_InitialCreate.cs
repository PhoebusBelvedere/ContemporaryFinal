using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContemporaryFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolYear = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GroupMembers",
                columns: new[] { "Id", "BirthDate", "Name", "Program", "SchoolYear" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian Wolfram", "Information Technology", "Junior" },
                    { 2, new DateTime(2004, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madeline Pederson", "Information Technology", "Junior" },
                    { 3, new DateTime(2005, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua Hampton", "Information Technology", "Junior" },
                    { 4, new DateTime(2004, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Han Nguyen", "Information Technology", "Senior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupMembers");
        }
    }
}
