using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Repository.Migrations
{
    /// <inheritdoc />
    public partial class TeacherAvatar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureUrl",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfilePictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfilePictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd826e1d-3f4e-4bf9-bf32-d017db776a21", "AQAAAAIAAYagAAAAEMZC+d3neGfSq6I+lA1BqIh7x/CEgKRYC9ggU1Y+t+VarBxcwzK8Q59vEhyhZ07bSg==", "c2c0196b-87c5-44ec-824d-9e455a98bf3a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2de8447b-cee3-4e12-8813-19c229953d8c", "AQAAAAIAAYagAAAAEDlptZ9C8WimKaK6nkvZL9QjAZep2k+qj00jg3yLbpAN9KPTbzIz39Fc7IK6T5yGJQ==", "e1036815-fb19-4c9d-af96-ecd50980d856" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14c54eca-b25f-4bd4-ae5a-4e7dc8e2f349", "AQAAAAIAAYagAAAAEN/HKX8aeZlIzNCn3bafe6v+SqNszZhPk67afprCiKB4xRUt8sf9WcLxPfy1bPFmyQ==", "56a02757-ed5c-40e3-ada2-075bcd0cf59b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureUrl",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef323a11-abeb-4073-89e1-7c7dfc702aeb", "AQAAAAIAAYagAAAAEFdO6ye+tKDr8ZB97pJK3/lRGlmmG8vYPVgmJ1mV1wXEbmNnc9G3eNYaoabBtrSngw==", "b3911d81-8c23-430c-9723-dd172819cc48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97804fca-2ad6-44a5-bf39-cb9db33f6fe8", "AQAAAAIAAYagAAAAEHyXoaJ5wvC990Y/RF+CueGiBCbaCsz0KV0wKre7Ri9yhvpsfYUcbvHO5zk81TXF7A==", "d2a80a95-4df7-458a-983d-a2a7655f970a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36a959fc-d61d-4601-be18-db7448b1a35d", "AQAAAAIAAYagAAAAEJNU6RRlIMVa2EFqs6PH7t04RMJyNB6xbjRqtRQyW+MR/KdmFb+L4e5oRJSpj851ow==", "6b34480a-77fc-49e4-b409-2adccfa57509" });
        }
    }
}
