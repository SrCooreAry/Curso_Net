namespace LeerData;

public class Instructor
{
    public int InstructorId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string ApePaterno { get; set; } = string.Empty;
    public string ApeMaterno { get; set; } = string.Empty;
    public int Grado { get; set; }
    public byte[]? Foto { get; set; }
    public ICollection<CursoInstructor> InstructorCurso { get; set; }
}
