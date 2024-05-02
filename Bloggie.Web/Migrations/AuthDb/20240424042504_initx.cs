using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blogpoint.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class initx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cccbb677-8047-4f00-a3bd-a5d1888e10d5", "AQAAAAIAAYagAAAAENS0K2HOhyAy1oHEf6W1et5jl3oatM0KkMFQqljFA2nexkUPszJToBwePYFO1Houbw==", "10f0ba17-4641-457b-9441-ca02f2a8e6f0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5ec0250-58fc-43fb-8b5f-fcc5fc511e36", "AQAAAAIAAYagAAAAENtJAZ5RZgkhlDaq2gqUe5d/U2GckvYXBZQDDbCPLHWts6SiBanO5LUTMmP6mxCRLg==", "7bc2b98b-c05a-4092-af30-efb7c1f26c27" });
        }
    }
}
