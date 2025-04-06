using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antivirus.Migrations
{
    /// <inheritdoc />
    public partial class RenameImageUrlToImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Services",
                newName: "image_url");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "Services",
                newName: "ImageUrl");
        }
    }
}
