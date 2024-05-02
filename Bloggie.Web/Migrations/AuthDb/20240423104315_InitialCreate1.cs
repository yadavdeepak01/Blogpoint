using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blogpoint.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5ec0250-58fc-43fb-8b5f-fcc5fc511e36", "AQAAAAIAAYagAAAAENtJAZ5RZgkhlDaq2gqUe5d/U2GckvYXBZQDDbCPLHWts6SiBanO5LUTMmP6mxCRLg==", "7bc2b98b-c05a-4092-af30-efb7c1f26c27" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c31e99-761a-420f-916e-3b0b44297a4e", "AQAAAAIAAYagAAAAEC8zAdKVnbQJnoNTuqen6wVrnV0YxJrt2KaJBpjxgUwhJlOLVDK1Oo5AIRZWRaVTQg==", "9ee9443e-8e5e-4ac5-90cf-3cca8d949a86" });
        }
    }
}
