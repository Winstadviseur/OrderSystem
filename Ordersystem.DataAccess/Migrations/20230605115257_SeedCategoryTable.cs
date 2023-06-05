﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ordersystem.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblCategory",
                columns: new[] { "Category_ID", "Category_Name" },
                values: new object[,]
                {
                    { 1, "Trucks" },
                    { 2, "Phones" },
                    { 3, "Sport" },
                    { 4, "Broadcast" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblCategory",
                keyColumn: "Category_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblCategory",
                keyColumn: "Category_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblCategory",
                keyColumn: "Category_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblCategory",
                keyColumn: "Category_ID",
                keyValue: 4);
        }
    }
}
