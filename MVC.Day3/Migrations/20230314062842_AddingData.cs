using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.Day3.Migrations
{
    /// <inheritdoc />
    public partial class AddingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "Severity", "Title" },
                values: new object[,]
                {
                    { 1, "Ergonomic Granite Car", 2, "Electronics, Sports & Electronics" },
                    { 2, "Soft", 0, "Health & Home" },
                    { 3, "Designer", 1, "Electronics & Jewelery" },
                    { 4, "morph", 2, "Toys, Health & Garden" },
                    { 5, "Vermont", 1, "Movies & Health" },
                    { 6, "navigating", 1, "Home" },
                    { 7, "redundant", 2, "Baby, Movies & Toys" },
                    { 8, "neural", 1, "Sports, Tools & Baby" },
                    { 9, "Oklahoma", 2, "Baby & Shoes" },
                    { 10, "SMTP", 1, "Music & Garden" },
                    { 11, "Future", 2, "Automotive" },
                    { 12, "Rubber", 0, "Computers, Baby & Games" },
                    { 13, "Point", 1, "Clothing & Games" },
                    { 14, "Fantastic Frozen Ball", 1, "Electronics, Kids & Games" },
                    { 15, "convergence", 2, "Books & Games" },
                    { 16, "haptic", 2, "Tools, Baby & Sports" },
                    { 17, "XSS", 0, "Automotive" },
                    { 18, "Toys", 2, "Jewelery & Tools" },
                    { 19, "Intelligent", 1, "Garden" },
                    { 20, "zero defect", 2, "Clothing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
