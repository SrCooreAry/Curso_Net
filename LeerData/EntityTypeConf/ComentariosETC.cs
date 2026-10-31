using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeerData.EntityTypeConf;
public class ComentariosETC : IEntityTypeConfiguration<Comentarios>
{
    public void Configure(EntityTypeBuilder<Comentarios> builder)
    {
        builder.ToTable("Comentarios");
        builder.HasKey("ComentarioId");

        builder.HasOne(c => c.Curso)
        .WithMany(cm => cm.Comentarios)
        .HasForeignKey(c => c.CursoId);
        //.OnDelete(DeleteBehavior.Cascade); Opcional: borrado en cascada;
    }

}
