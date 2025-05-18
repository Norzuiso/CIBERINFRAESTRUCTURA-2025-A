using Microsoft.EntityFrameworkCore;
using CrudStudentAPI.Models;

namespace CrudStudentAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}