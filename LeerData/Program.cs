using Microsoft.EntityFrameworkCore;

namespace LeerData;
class Program
{
    static void Main(string[] args)
    {
        using var db = new CursosOnlineContext();
        //para consultar la tabla intermedia
        var cursoInstructor = db.CursoInstructor.Include(d => d.Curso).Include(c => c.Instructor).AsNoTracking();
        foreach(CursoInstructor ci in cursoInstructor)
        {
            Console.WriteLine($"Curso: {ci.Curso.Titulo} --- Docente: {ci.Instructor.Nombre}");
        }

        //para consultar a partir de una tabla en este caso Curso - CursoInstructor - instructor
        //obtienes el instructor a partir de la relacion entre curso y cursoinstructor ya que estan anclados/vinculados
        var cuins = db.Curso.Include(d => d.CursoInstructor).ThenInclude(d => d.Instructor);
        foreach(Curso curso in cuins)
        {
            Console.WriteLine($"Curso: {curso.Titulo}");
            foreach(CursoInstructor curin in curso.CursoInstructor)
            {
                Console.WriteLine($"instructor: {curin.Instructor.Nombre} asdasdsa");
            }
        }
        
    }
}