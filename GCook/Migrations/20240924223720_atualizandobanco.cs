using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GCook.Migrations
{
    /// <inheritdoc />
    public partial class atualizandobanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7600c5dc-e5a4-4b73-b465-3e2accda5949", "AQAAAAIAAYagAAAAEIqIzxsJybGjz2/D28g3fUL9NWXIOirueiGgjj5NvXekQAI9Y2MwbH7M3gSIpdgmoQ==", "5f87b2ce-8892-4fbe-a746-28c25d410e37" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8631fc84-ac51-4187-b1eb-5f8ae48ee341", "AQAAAAIAAYagAAAAEKJP07XsTWMjZtD8Fi1GrHf5dK7TtGJdLPWiwhQez6gJQdd005ZiLXIzKFsAEIiijA==", "73a87d92-c266-4e35-a3f2-bca0d8894a9d" });
        }
    }
}
