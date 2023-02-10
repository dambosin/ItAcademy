using ItAcademy.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ItAcademy.Data
{
    public class NewsContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public NewsContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
