namespace LeerData;

public class Comentarios
{
    public int ComentarioId { get; set; }
    public string Alumno { get; set; } = string.Empty;
    public decimal Puntaje { get; set; }
    public int CursoId { get; set; }
    public Curso Curso { get; set; }
}
