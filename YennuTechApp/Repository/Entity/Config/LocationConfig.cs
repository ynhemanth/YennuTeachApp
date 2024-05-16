using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity.Model;

namespace Repository.Entity.Config
{
    public class LocationConfig : IEntityTypeConfiguration<LocationEntity>
    {
        public void Configure(EntityTypeBuilder<LocationEntity> builder)
        {
            builder.ToTable("Locations");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(n => n.Code).IsRequired();
            builder.Property(n => n.Name).HasMaxLength(250);
            builder.Property(n => n.CreatedDate).IsRequired(false).HasMaxLength(500);            
        }
    }
}
