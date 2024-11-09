using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea7.Migrations
{
    /// <inheritdoc />
    public partial class AddApellidoColumnToDetenido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "Detenidos");

            migrationBuilder.DropColumn(
                name: "NombreApellido",
                table: "Detenidos");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroPasaporte",
                table: "Detenidos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Detenidos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitud",
                table: "Detenidos",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitud",
                table: "Detenidos",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Detenidos",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Detenidos");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Detenidos");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Detenidos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Detenidos");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroPasaporte",
                table: "Detenidos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coordenadas",
                table: "Detenidos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreApellido",
                table: "Detenidos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
