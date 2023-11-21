using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace p1.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatarr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "HouseId", "Address", "NumberFloors", "YearConstruction" },
                values: new object[,]
                {
                    { new Guid("a539dd53-125b-4eef-9cbe-ab9d9b5bfdd8"), "Саранск, ул. Лесная, 64", 5, 2006 },
                    { new Guid("cf07407f-a0c4-46cc-870b-850d29c6ac93"), "Саранск, ул. Коммунистическая, 25а", 9, 2010 }
                });

            migrationBuilder.InsertData(
                table: "Apartment",
                columns: new[] { "ApartmentId", "ApartmentNumber", "Cost", "HouseId", "NumberRooms" },
                values: new object[,]
                {
                    { new Guid("1e707554-3a47-43d1-aae7-e990d385081b"), 10, "6000000", new Guid("cf07407f-a0c4-46cc-870b-850d29c6ac93"), 4 },
                    { new Guid("4d57c4a3-b6c3-464f-bad1-6550d4bf3182"), 15, "4000000", new Guid("cf07407f-a0c4-46cc-870b-850d29c6ac93"), 2 },
                    { new Guid("621d298f-8734-4cbb-814b-9a126c5ba0da"), 8, "4500000", new Guid("cf07407f-a0c4-46cc-870b-850d29c6ac93"), 3 },
                    { new Guid("d67977ae-cb1a-4747-8a02-2b0b2e7d1bd8"), 17, "2500000", new Guid("a539dd53-125b-4eef-9cbe-ab9d9b5bfdd8"), 1 },
                    { new Guid("e4ce4d0b-0725-4a56-8ce9-49333bc3682a"), 28, "2800000", new Guid("a539dd53-125b-4eef-9cbe-ab9d9b5bfdd8"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apartment",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1e707554-3a47-43d1-aae7-e990d385081b"));

            migrationBuilder.DeleteData(
                table: "Apartment",
                keyColumn: "ApartmentId",
                keyValue: new Guid("4d57c4a3-b6c3-464f-bad1-6550d4bf3182"));

            migrationBuilder.DeleteData(
                table: "Apartment",
                keyColumn: "ApartmentId",
                keyValue: new Guid("621d298f-8734-4cbb-814b-9a126c5ba0da"));

            migrationBuilder.DeleteData(
                table: "Apartment",
                keyColumn: "ApartmentId",
                keyValue: new Guid("d67977ae-cb1a-4747-8a02-2b0b2e7d1bd8"));

            migrationBuilder.DeleteData(
                table: "Apartment",
                keyColumn: "ApartmentId",
                keyValue: new Guid("e4ce4d0b-0725-4a56-8ce9-49333bc3682a"));

            migrationBuilder.DeleteData(
                table: "House",
                keyColumn: "HouseId",
                keyValue: new Guid("a539dd53-125b-4eef-9cbe-ab9d9b5bfdd8"));

            migrationBuilder.DeleteData(
                table: "House",
                keyColumn: "HouseId",
                keyValue: new Guid("cf07407f-a0c4-46cc-870b-850d29c6ac93"));
        }
    }
}
