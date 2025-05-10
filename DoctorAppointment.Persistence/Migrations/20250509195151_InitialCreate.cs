using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 5, 12, 22, 51, 50, 921, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 5, 11, 22, 51, 50, 926, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 5, 10, 22, 51, 50, 926, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ee89832c-394f-447f-a544-967f5cc2be3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "830056e8-f5ba-4b6d-9344-18b7ff1986d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "542726bd-7020-4658-9f03-390e1ae539f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab28c86e-d71e-47f5-9668-2b74233957ba", "AQAAAAIAAYagAAAAENXUPQ6ATZqoWVLtoO5frj8LEB/7GkE8w61QVobMcZQuodUlX9m6VCQzdcVVNlzRfg==", "a9313257-d939-4788-b1e1-62f9ec4bf5b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2211490a-c5e6-4266-be6d-3ece1650633d", "AQAAAAIAAYagAAAAENKeT1V3QijflRrLMAn+lKeMR+fsulHZ2ynO9W6qhEN2H1tYq5UWcwnywefJeAQeGA==", "2d0df1a0-3611-464a-843d-eda4f3febe0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2882f288-ff22-4276-a086-26feec78468a", "AQAAAAIAAYagAAAAEKGN258fSzvsgiqhIIgT1ouAi0phcaxPxfN+gkOygqejSxxyhcGTliOIq786QH8aHg==", "dad9bcda-c081-4a31-b03e-2dae8e58dc1d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 15, 12, 13, 38, 454, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 14, 12, 13, 38, 454, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 13, 12, 13, 38, 454, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ffea4d94-ab5b-43cc-915a-81aa890b8578");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7cad8e26-b07f-43ff-b7ee-d339a6d351c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5ee0798a-33c2-4eb2-a196-ce04cd2d9263");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e30080f0-2c00-4804-b8f5-3fb1ab46c241", "AQAAAAIAAYagAAAAEGar3u0CC2N7erwuyQSoIHVjehpdzQ8p/sRZn/GNym+xob5IM7ypfrXotCoQD6C9yw==", "fe560e1b-be47-4b53-ac29-8afdf650e260" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "097e7e95-7e0b-4f0c-ad89-8cf9da3386fb", "AQAAAAIAAYagAAAAEHENfouxnBlrR3th4mxGZNU5A25Qx5kHjBHdpIKeXRrejvP90BBdjTzwf7oivSH4QA==", "7954084e-89df-4e39-bdfa-bd01e27d5080" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fddd37fd-90f6-43e7-9f42-258bba649def", "AQAAAAIAAYagAAAAENQRFzUExU3qXdSeilbioiXZ6c+ws79YLAWEdxdIEmiVrhFjmoberKuAhmV3TGDu+w==", "90706ccc-3576-49f8-8123-faed85639aa8" });
        }
    }
}
