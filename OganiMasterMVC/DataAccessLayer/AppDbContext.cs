using Microsoft.EntityFrameworkCore;
using OganiMasterMVC.DataAccessLayer.Entities;

namespace OganiMasterMVC.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Banners> Banners { get; set; }
        public DbSet<SliderCategories> SliderCategories { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<FeaturedCategories> FeaturedCategories { get; set; }
    }
}
