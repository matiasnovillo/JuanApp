using JuanApp.Areas.JuanApp.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace JuanApp.Areas.JuanApp.EntitiesConfiguration
{
    public class RemitoConfiguration : IEntityTypeConfiguration<Remito>
    {
        public void Configure(EntityTypeBuilder<Remito> entity)
        {
            try
            {
                //RemitoId
                entity.HasKey(e => e.RemitoId);
                entity.Property(e => e.RemitoId)
                    .ValueGeneratedOnAdd();

                //Active
                entity.Property(e => e.Active)
                    .HasColumnType("tinyint")
                    .IsRequired(true);

                //DateTimeCreation
                entity.Property(e => e.DateTimeCreation)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //DateTimeLastModification
                entity.Property(e => e.DateTimeLastModification)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //UserCreationId
                entity.Property(e => e.UserCreationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //UserLastModificationId
                entity.Property(e => e.UserLastModificationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //Fecha
                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //KilosTotales
                entity.Property(e => e.KilosTotales)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //PrecioTotal
                entity.Property(e => e.PrecioTotal)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //SubtotalTotal
                entity.Property(e => e.SubtotalTotal)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //CodigoCliente
                entity.Property(e => e.CodigoCliente)
                    .HasColumnType("varchar(500)")
                    .IsRequired(true);

                //NombreCliente
                entity.Property(e => e.NombreCliente)
                    .HasColumnType("varchar(8000)")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
