using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GCook.Migrations
{
    /// <inheritdoc />
    public partial class atualizabanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8631fc84-ac51-4187-b1eb-5f8ae48ee341", "AQAAAAIAAYagAAAAEKJP07XsTWMjZtD8Fi1GrHf5dK7TtGJdLPWiwhQez6gJQdd005ZiLXIzKFsAEIiijA==", "73a87d92-c266-4e35-a3f2-bca0d8894a9d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67ce5adb-e79e-4c4f-a8c9-9e35e6dcbac3", "AQAAAAIAAYagAAAAEL00J/wh8bbSv2VStnpdhqW7fIqWzYyHeNkHTT8zJ24vkfbY4fGqBbP7PMg4DuAY9Q==", "ad8d0591-ceb1-4651-a422-d427aef11fb6" });
        }
    }
}
