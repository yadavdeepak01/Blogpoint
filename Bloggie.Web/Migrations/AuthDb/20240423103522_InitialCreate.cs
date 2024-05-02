using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blogpoint.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f9c31e99-761a-420f-916e-3b0b44297a4e", "superadmin@blogpoint.com", "AQAAAAIAAYagAAAAEC8zAdKVnbQJnoNTuqen6wVrnV0YxJrt2KaJBpjxgUwhJlOLVDK1Oo5AIRZWRaVTQg==", "9ee9443e-8e5e-4ac5-90cf-3cca8d949a86", "superadmin@blogpoint.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fbc92924-fd90-4c5f-ad3c-963362cdc10c", "superadmin@Blogpoint.com", "AQAAAAIAAYagAAAAEJ3vzy0G8BQSxEBPvbwXSiyRgEhSngKdCBf99PbfTLMWOnZo8mFKM0/HvZo4wiAzEQ==", "85c1c7ca-8d7f-439c-8f7a-a94b94d0bffa", "superadmin@Blogpoint.com" });
        }
    }
}
