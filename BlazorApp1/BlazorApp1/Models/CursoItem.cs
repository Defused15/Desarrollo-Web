namespace BlazorApp1.Models
{
    public record CursoItem(
        string Codigo,
        string Nombre,
        string Descripcion,
        int Matriculados,
        decimal PrecioXAlumno,
        string Estado);
}
