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
    public class LocalMap : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.ToTable("Local");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Localdesc)
                .IsRequired()
                .HasColumnType("varchar(80)");

            /*builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(45)");*/

            builder.HasOne(prop => prop.Nome);

        }
    }
}
