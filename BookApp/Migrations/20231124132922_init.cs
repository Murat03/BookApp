using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Body", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lobortis scelerisque fermentum dui faucibus. In hac habitasse platea dictumst quisque sagittis purus sit. At lectus urna duis convallis convallis tellus id interdum. Mauris vitae ultricies leo integer malesuada nunc. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Ultrices gravida dictum fusce ut placerat orci nulla. Interdum velit euismod in pellentesque massa placerat. Quam viverra orci sagittis eu volutpat odio facilisis mauris sit. Consequat id porta nibh venenatis cras sed. Malesuada fames ac turpis egestas. Eget dolor morbi non arcu risus quis varius quam quisque. Volutpat ac tincidunt vitae semper. Eu mi bibendum neque egestas congue quisque egestas. Ultrices tincidunt arcu non sodales. Id ornare arcu odio ut sem nulla pharetra diam sit.", "Title" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
