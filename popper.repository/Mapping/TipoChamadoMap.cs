using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using popper.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace popper.repository.Mapping
{
    public class TipoChamadoMap : IEntityTypeConfiguration<TipoChamado>
    {
        public void Configure(EntityTypeBuilder<TipoChamado> builder)
        {
            builder.ToTable("TipoChamado");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Tecnico_idtecnico);

            builder.Property(prop => prop.Tipo)
             .IsRequired()
             .HasColumnType("varchar(20)");

        }
    }
}
