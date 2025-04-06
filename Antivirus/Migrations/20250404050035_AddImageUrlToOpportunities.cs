using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antivirus.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToOpportunities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Elimina esta línea porque intenta eliminar una columna que no existe
            // migrationBuilder.DropColumn(
            //     name: "PasswordHash",
            //     table: "users");

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "opportunities",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_url",
                table: "opportunities");

            // Elimina esta línea porque intenta agregar una columna que no necesitas
            // migrationBuilder.AddColumn<string>(
            //     name: "PasswordHash",
            //     table: "users",
            //     type: "text",
            //     nullable: false,
            //     defaultValue: "");
        }
    }
}