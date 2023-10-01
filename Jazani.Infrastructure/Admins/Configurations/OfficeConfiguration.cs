using Microsoft.EntityFrameworkCore;
using Jazani.Domain.Admins.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Jazani.Infrastructure.Admins.Configurations
{
    public class OfficeConfiguration: IEntityTypeConfiguration<Office>
    {
        //Configuración de la entidad Office
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("office", "adm");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(x => x.State).HasColumnName("state");
        }
    }
}
