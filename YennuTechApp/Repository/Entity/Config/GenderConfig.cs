using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity.Model;

namespace Repository.Entity.Config
{
    public class GenderConfig : IEntityTypeConfiguration<GenresEntity>
    {
        public void Configure(EntityTypeBuilder<GenresEntity> builder)
        {
            builder.ToTable("Genre");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();            
            builder.Property(n => n.Name).HasMaxLength(250);
            builder.Property(n => n.CreatedDate).IsRequired(false).HasMaxLength(500);
        }
    }
}
