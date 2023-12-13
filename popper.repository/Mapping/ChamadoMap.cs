
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


            builder.Property(prop => prop.Tipo)
                .IsRequired()
                .HasColumnType("varchar(20)");


            builder.HasOne(prop => prop.Usuario);

            builder.HasOne(prop => prop.Local);

            builder.HasOne(prop => prop.TipoChamado);

            builder.HasOne(prop => prop.Tecnico);
        }
    }
}
