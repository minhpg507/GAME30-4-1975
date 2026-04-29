using Microsoft.EntityFrameworkCore;
using TocHanhAPI.Models;

namespace TocHanhAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Leaderboard> Leaderboards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Kết nối class này với bảng Leaderboard trong SQL
            modelBuilder.Entity<Leaderboard>().ToTable("Leaderboard");
        }
    }
}