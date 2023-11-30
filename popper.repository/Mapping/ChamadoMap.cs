
using popper.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace popper.repository.Mapping
{
    public class ChamadoMap : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("Chamado");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Desc)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Status)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Hora)
                .HasDefaultValue(DateTime.Now);

            builder.Property(prop => prop.Tecnico_idtecnico);

            builder.Property(prop => prop.Usuario_idusuario);

            builder.Property(prop => prop.Local_idlocal);

            builder.Property(prop => prop.TipoChamado_idtipochamado);
        }
    }
}
