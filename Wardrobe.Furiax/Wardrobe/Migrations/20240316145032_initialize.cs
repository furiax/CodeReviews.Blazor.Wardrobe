using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wardrobe.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cloths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cloths", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cloths",
                columns: new[] { "Id", "Brand", "Color", "ImageUrl", "Type" },
                values: new object[,]
                {
                    { 1, "Jack & Jones", "blue", "https://images.jackjones.com/12237367/4239534/001/jackjones-gedruktt-shirtvoorjongens-blauw.jpg?v=45584ed700fb0f028ac104ed43721306&format=webp&width=1280&quality=90&key=25-0-3", 0 },
                    { 2, "Lee Cooper", "blue", "https://cf75d1d9c.cloudimg.io/v7/imageserver/original/LC110ZP_ECO%20MID%20BLUE.jpg", 5 },
                    { 3, "Addidas", "white", "https://i8.amplience.net/i/jpl/jd_348391_a?qlt=92&w=750&h=531&v=1&fmt=auto", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cloths");
        }
    }
}
