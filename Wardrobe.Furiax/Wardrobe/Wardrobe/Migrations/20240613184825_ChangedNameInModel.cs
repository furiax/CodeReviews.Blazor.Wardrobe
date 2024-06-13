using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wardrobe.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNameInModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "ClothPieces",
                newName: "Image");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "ClothPieces",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "ClothPieces",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ClothPieces",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://www.torfs.be/dw/image/v2/BCQR_PRD/on/demandware.static/-/Sites-torfs-catalog-master/default/dwe08d8d54/hi-res/pdp/319/319013/319013-3.jpg?sw=820");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "ClothPieces",
                newName: "ImageUrl");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "ClothPieces",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "ClothPieces",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "ClothPieces",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://i8.amplience.net/i/jpl/jd_348391_a?qlt=92&w=750&h=531&v=1&fmt=auto");
        }
    }
}
