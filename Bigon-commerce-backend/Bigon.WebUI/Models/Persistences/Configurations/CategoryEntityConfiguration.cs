﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Bigon.WebUI.Models.Entities;

namespace Bigon.WebUI.Models.Persistences.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(m => m.Id).UseIdentityColumn(1, 1);
            builder.Property(m => m.ParentId).HasColumnType("int");
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.ConfigureAsAuditable();

            builder.HasOne<Category>()
                .WithMany()
                .HasForeignKey(m => m.ParentId)
                .HasPrincipalKey(m => m.Id);

            builder.HasKey(m => m.Id);
            builder.ToTable("Categories");
        }
    }
}
