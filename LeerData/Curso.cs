namespace LeerData;

public class Curso
{
    public int CursoId { get; set; }
    public string Titulo {get;set;} = string.Empty;
    public string Descripcion {get; set;} = string.Empty;
    public DateTime FechaPublicacion { get; set;} = DateTime.Now;
    public byte[]? FotoPortada { get; set;}
    public Precio Precio { get; set;}
    public ICollection<Comentarios> Comentarios { get; set; }
    public ICollection<CursoInstructor> CursoInstructor { get; set; }
}
