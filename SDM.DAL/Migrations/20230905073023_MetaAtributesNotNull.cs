using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDM.DAL.Migrations
{
    /// <inheritdoc />
    public partial class MetaAtributesNotNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MetaTitle",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaKeywords",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaDescription",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaTitle",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaKeywords",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MetaDescription",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a7a32e-20fa-4935-a495-18ccbb5df3a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "870c7877-ffa6-449e-8ac8-e327a4501feb", "AQAAAAIAAYagAAAAEGGAKxRAwmJDn1XrExvcg42o/pG3AWCFZuhkAWb6t1Ha6gP1bygWJa21XNR2GJopXw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1573a0a1-2914-4164-ab0d-ebabe87ddc38"),
                columns: new[] { "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle" },
                values: new object[] { new DateTime(2023, 9, 5, 7, 30, 23, 289, DateTimeKind.Utc).AddTicks(1970), "Метатег не установлен", "Метатег не установлен", "Метатег не установлен" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("574cc2ea-3eeb-4498-b007-bc537ebf92ff"),
                columns: new[] { "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle" },
                values: new object[] { new DateTime(2023, 9, 5, 7, 30, 23, 289, DateTimeKind.Utc).AddTicks(1929), "Метатег не установлен", "Метатег не установлен", "Метатег не установлен" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("9dd7a39a-4bd9-4c21-bc21-88f391cc70ed"),
                columns: new[] { "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle" },
                values: new object[] { new DateTime(2023, 9, 5, 7, 30, 23, 289, DateTimeKind.Utc).AddTicks(1985), "Метатег не установлен", "Метатег не установлен", "Метатег не установлен" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MetaTitle",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MetaKeywords",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MetaDescription",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MetaTitle",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MetaKeywords",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MetaDescription",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a7a32e-20fa-4935-a495-18ccbb5df3a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fd65c86-2536-4a0e-8782-ed8619651585", "AQAAAAIAAYagAAAAELBt9S/ix6pOXe9s6pcw/pk1dU3Yl1TGejY9LEKTdU/IY5BqkmkZvnKrz7JLriKseQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1573a0a1-2914-4164-ab0d-ebabe87ddc38"),
                columns: new[] { "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle" },
                values: new object[] { new DateTime(2023, 9, 3, 8, 57, 31, 231, DateTimeKind.Utc).AddTicks(9711), null, null, null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("574cc2ea-3eeb-4498-b007-bc537ebf92ff"),
                columns: new[] { "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle" },
                values: new object[] { new DateTime(2023, 9, 3, 8, 57, 31, 231, DateTimeKind.Utc).AddTicks(9670), null, null, null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("9dd7a39a-4bd9-4c21-bc21-88f391cc70ed"),
                columns: new[] { "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle" },
                values: new object[] { new DateTime(2023, 9, 3, 8, 57, 31, 231, DateTimeKind.Utc).AddTicks(9726), null, null, null });
        }
    }
}
