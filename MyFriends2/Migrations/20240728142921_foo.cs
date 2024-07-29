using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFriends2.Migrations
{
    /// <inheritdoc />
    public partial class foo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyImage",
                table: "Image",
                newName: "ImageData");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "Image",
                newName: "MyImage");
        }
    }
}
