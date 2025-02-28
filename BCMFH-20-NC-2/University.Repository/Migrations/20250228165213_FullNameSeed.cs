using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Repository.Migrations
{
    /// <inheritdoc />
    public partial class FullNameSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef323a11-abeb-4073-89e1-7c7dfc702aeb", "ADMIN", "AQAAAAIAAYagAAAAEFdO6ye+tKDr8ZB97pJK3/lRGlmmG8vYPVgmJ1mV1wXEbmNnc9G3eNYaoabBtrSngw==", "b3911d81-8c23-430c-9723-dd172819cc48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97804fca-2ad6-44a5-bf39-cb9db33f6fe8", "Giorgi Giorgadze", "AQAAAAIAAYagAAAAEHyXoaJ5wvC990Y/RF+CueGiBCbaCsz0KV0wKre7Ri9yhvpsfYUcbvHO5zk81TXF7A==", "d2a80a95-4df7-458a-983d-a2a7655f970a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36a959fc-d61d-4601-be18-db7448b1a35d", "Nika Chkahrtishvili", "AQAAAAIAAYagAAAAEJNU6RRlIMVa2EFqs6PH7t04RMJyNB6xbjRqtRQyW+MR/KdmFb+L4e5oRJSpj851ow==", "6b34480a-77fc-49e4-b409-2adccfa57509" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9ffe450-ed11-4b75-8168-11d511b7eea7", null, "AQAAAAIAAYagAAAAENNkdAveNorYJOAl/Hr/ZW/XIHroPZ5vIQ40RVlunIrI8Tt6oHOqjK9uBgffCNBq2g==", "ae42937b-ae98-4420-bea5-163bcfbc4b0b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de78b877-700d-4848-9bd2-f00177b92e8d", null, "AQAAAAIAAYagAAAAED1RJEZfv16lLoskBvqMgLW44nYd7tBUIS0REQXAkSmqeczW8MO93N3uR89Gj9veVA==", "0d33dbc8-d7bc-46b3-aa33-74d0ef14377a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c56c28-a49f-4037-ba47-31cdca4ec6ae", null, "AQAAAAIAAYagAAAAEOA3fb87gbymibF6nCm2RUfyeiPd9M/r2AKu7xRaPgdDmaCrnybRFgdtuBmYPCdA9A==", "f127618b-e4a7-4bb3-a6bd-20a432a024ad" });
        }
    }
}
