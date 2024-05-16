using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity.Model;

namespace Repository.Entity.Config
{
    public class MovieConfig : IEntityTypeConfiguration<MovieEntity>
    {
        public void Configure(EntityTypeBuilder<MovieEntity> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(n => n.Title).IsRequired();
            builder.Property(n => n.Directors).HasMaxLength(250);
            builder.Property(n => n.Synopsis).HasMaxLength(250);
            builder.Property(n => n.ReleaseDate).IsRequired().HasMaxLength(500);
            builder.Property(n => n.CreatedDate).IsRequired(false).HasMaxLength(500);
        }
    }
}
