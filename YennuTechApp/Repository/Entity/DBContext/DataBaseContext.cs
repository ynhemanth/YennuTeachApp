using Microsoft.EntityFrameworkCore;
using Repository.Entity.Model;

namespace Repository.Entity.DBContext
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<AgeRestrictionEntity> AgeRestrictions { get; set; }
        public DbSet<GenresEntity> Genres { get; set; }
        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<MovieGenresEntity> MovieGenres { get; set; }
        public DbSet<ScreenEntity> Screens { get; set; }
        public DbSet<ShowsEntity> Shows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<LocationEntity>().HasData(new List<LocationEntity>()
            //{ 
            //    new() {
            //        Code = "LON",
            //        CreatedDate = DateTime.Now,
            //        Name = "London"
            //    },
            //      new() {
            //        Code = "MAN",
            //        CreatedDate = DateTime.Now,
            //        Name = "Manchester"
            //    },
            //      new() {
            //        Code = "Con",
            //        CreatedDate = DateTime.Now,
            //        Name = "Conwall"
            //    },
            //      new() {
            //        Code = "EDIN",
            //        CreatedDate = DateTime.Now,
            //        Name = "Edinburgh"
            //    }
            //});
        }

    }
}
