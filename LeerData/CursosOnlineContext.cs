
using Microsoft.EntityFrameworkCore;

namespace LeerData;

public class CursosOnlineContext : DbContext
{
    private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
   
    public DbSet<Curso> Curso { get; set; }
    public DbSet<Precio> Precio { get; set; }
    public DbSet<Comentarios> Comentarios {get;set;}
    public DbSet<Instructor> Instructor { get; set; }
    public DbSet<CursoInstructor> CursoInstructor { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Busca automáticamente todas las configuraciones en el ensamblado actual (proyecto). Ej carpeta EntityTypeConf
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CursosOnlineContext).Assembly);
    }

}
