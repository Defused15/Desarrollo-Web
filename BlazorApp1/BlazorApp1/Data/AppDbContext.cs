using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CursoEntity> Cursos => Set<CursoEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Evitar códigos duplicados en la base de datos
            modelBuilder.Entity<CursoEntity>()
                .HasIndex(c => c.Codigo)
                .IsUnique();

            // Datos iniciales (los mismos 4 cursos que ya había en el dashboard)
            modelBuilder.Entity<CursoEntity>().HasData(
                new CursoEntity { Id = 1, Codigo = "DWM-101", Nombre = "Desarrollo Web y Móvil", Descripcion = "Fundamentos de HTML5, CSS3, Blazor y PWAs multiplataforma.", Matriculados = 28, PrecioXAlumno = 50m, Estado = "Activo" },
                new CursoEntity { Id = 2, Codigo = "DWM-102", Nombre = "Cloud Native & Microservicios", Descripcion = "Despliegues en contenedores Docker y arquitecturas escalables.", Matriculados = 24, PrecioXAlumno = 40m, Estado = "Activo" },
                new CursoEntity { Id = 3, Codigo = "DWM-103", Nombre = "Seguridad y Auditoría Web", Descripcion = "Análisis de vulnerabilidades OWASP y autenticación JWT.", Matriculados = 19, PrecioXAlumno = 35m, Estado = "En Revisión" },
                new CursoEntity { Id = 4, Codigo = "DWM-104", Nombre = "UI/UX & Design Systems", Descripcion = "Prototipado interactivo, accesibilidad WCAG y Figma.", Matriculados = 31, PrecioXAlumno = 50m, Estado = "Activo" }
            );
        }
    }
}
