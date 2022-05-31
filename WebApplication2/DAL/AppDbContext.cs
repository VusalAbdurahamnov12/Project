using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Comments> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<OurSocial> OurSocials { get; set; }
        public DbSet<Partnior> Partniors { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Slogan> Slogans { get; set; }
        public DbSet<Statistica> Statisticas { get; set; }
        public DbSet<Team> Teams { get; set;}
        public DbSet<TeamSocial> TeamSocials { get; set; }

    }
}
