﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Annual_Dinner_Feedback.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Question1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question7 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
