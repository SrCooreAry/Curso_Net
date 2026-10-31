using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeerData.EntityTypeConf;
public class CursoETC : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");
        builder.HasKey(d => d.CursoId);

        // 1:1 
        builder.HasOne(d => d.Precio) //curso tiene un precio y apunta a la propiedad de la calse curso "Precio"
        .WithOne(d => d.Curso) //indica que precio se conecta con un curso y apunta a "idCurso" de precio
        .HasForeignKey<Precio>(d => d.CursoId); //se indica que la columna de la calve foranea se crea en Precio en la columna CursoId

        //Configuracion columnas
        builder.Property(d => d.Titulo)
        .HasColumnType("varchar(500)")
        .HasMaxLength(500)
        .IsRequired();

        builder.Property(d => d.Descripcion)
        .HasColumnType("varchar(1000)")
        .HasMaxLength(1000);

        builder.Property(d => d.FechaPublicacion)
        .HasColumnType("datetime")
        .IsRequired();

    }
}
