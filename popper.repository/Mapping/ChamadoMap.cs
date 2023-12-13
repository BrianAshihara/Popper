
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

            builder.Property(prop => prop.Tipo)
                .IsRequired()
                .HasColumnType("varchar(20)");

           /* builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(45)");*/


            builder.HasOne(prop => prop.Tecnico_idtecnico);

            builder.HasOne(prop => prop.Usuario_idusuario);

            builder.HasOne(prop => prop.Local_idlocal);

            builder.HasOne(prop => prop.TipoChamado_idtipochamado);

            builder.HasOne(prop => prop.Nome);

            builder.HasOne(prop => prop.Tecnico);
        }
    }
}
