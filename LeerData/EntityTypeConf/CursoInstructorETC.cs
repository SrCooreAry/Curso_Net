using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeerData.EntityTypeConf;
public class CursoInstructorETC : IEntityTypeConfiguration<CursoInstructor>
{
    public void Configure(EntityTypeBuilder<CursoInstructor> builder)
    {
        builder.ToTable("CursoInstructor");

        builder.HasKey(ci => new
        {
           ci.CursoId,
           ci.InstructorId 
        });

        builder.HasOne(sc => sc.Curso)
        .WithMany(c => c.CursoInstructor)
        .HasForeignKey(sc => sc.CursoId);

        builder.HasOne(sc => sc.Instructor)
        .WithMany(i => i.InstructorCurso)
        .HasForeignKey(sc => sc.InstructorId);

    }
}
