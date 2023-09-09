using Bigon.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bigon.WebUI.Models.Persistences.Configurations
{
    public class MaterialEntityConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.Property(m => m.Id).UseIdentityColumn(1, 1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.ConfigureAsAuditable();


            builder.HasKey(m => m.Id);
            builder.ToTable("Materials");
        }
    }
}
