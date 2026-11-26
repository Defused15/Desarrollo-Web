using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
    [Table("Cursos")]
    public class CursoEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Codigo { get; set; } = "";

        [Required, MaxLength(120)]
        public string Nombre { get; set; } = "";

        [MaxLength(250)]
        public string Descripcion { get; set; } = "";

        [Range(0, 500)]
        public int Matriculados { get; set; }

        public decimal PrecioXAlumno { get; set; }

        [MaxLength(20)]
        public string Estado { get; set; } = "Activo";

        public string? NombreTemario { get; set; }
    }
}
