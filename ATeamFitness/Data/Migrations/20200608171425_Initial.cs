using Microsoft.EntityFrameworkCore.Migrations;

namespace ATeamFitness.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d42ca736-15ac-47c2-8e4a-9a12415d013b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1fad4c8-d06a-4101-a8d8-3613f0f81e35");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0126bdf7-dcba-4930-9127-22e4ca76142b", "35161b09-c70e-488a-b7ca-238338bba681", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58681d03-a8f5-4ffa-89d8-90e521763d12", "a7b980f2-5b5d-4fd5-848a-39da627c02c7", "PersonTrainer", "PERSONAL TRAINER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0126bdf7-dcba-4930-9127-22e4ca76142b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58681d03-a8f5-4ffa-89d8-90e521763d12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d42ca736-15ac-47c2-8e4a-9a12415d013b", "5a902024-6fcc-415f-837f-ed3eb3ff2f79", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1fad4c8-d06a-4101-a8d8-3613f0f81e35", "2257ca17-1bb1-4fcc-8792-9a74e7b12f13", "PersonTrainer", "PERSONAL TRAINER" });
        }
    }
}
