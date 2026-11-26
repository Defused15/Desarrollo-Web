using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Matriculados = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioXAlumno = table.Column<decimal>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NombreTemario = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Codigo", "Descripcion", "Estado", "Matriculados", "Nombre", "NombreTemario", "PrecioXAlumno" },
                values: new object[,]
                {
                    { 1, "DWM-101", "Fundamentos de HTML5, CSS3, Blazor y PWAs multiplataforma.", "Activo", 28, "Desarrollo Web y Móvil", null, 50m },
                    { 2, "DWM-102", "Despliegues en contenedores Docker y arquitecturas escalables.", "Activo", 24, "Cloud Native & Microservicios", null, 40m },
                    { 3, "DWM-103", "Análisis de vulnerabilidades OWASP y autenticación JWT.", "En Revisión", 19, "Seguridad y Auditoría Web", null, 35m },
                    { 4, "DWM-104", "Prototipado interactivo, accesibilidad WCAG y Figma.", "Activo", 31, "UI/UX & Design Systems", null, 50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_Codigo",
                table: "Cursos",
                column: "Codigo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
