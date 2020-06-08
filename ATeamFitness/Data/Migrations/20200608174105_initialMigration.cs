using Microsoft.EntityFrameworkCore.Migrations;

namespace ATeamFitness.Data.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0480e623-fe46-4bbb-85ae-dbb97d884a87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "722743c5-5143-4979-90f2-5a35027fdc97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b39f8487-64c8-435a-9e4e-5822791f9c19", "ebf08129-73ba-411a-88dc-57c482c1e5b0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b1a57cc-ae51-4028-a83b-b5c02a0a1bbc", "2ee5c753-06e5-4a71-834a-e33b7dc0ff6b", "PersonTrainer", "PERSONAL TRAINER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b1a57cc-ae51-4028-a83b-b5c02a0a1bbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b39f8487-64c8-435a-9e4e-5822791f9c19");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "722743c5-5143-4979-90f2-5a35027fdc97", "700183d0-c2ab-4720-a2de-7fb8f21a7161", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0480e623-fe46-4bbb-85ae-dbb97d884a87", "cf6f80a1-fad8-45ea-aac9-5c0e36ab416f", "PersonTrainer", "PERSONAL TRAINER" });
        }
    }
}
