using Microsoft.EntityFrameworkCore;
using WebApiDock.Entity;

namespace WebApiDock.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().HasKey(u => u.Id);
      modelBuilder.Entity<User>()
        .Property(u => u.Name)
        .IsRequired()
        .HasMaxLength(50);
      modelBuilder.Entity<User>()
        .Property(u => u.LastName)
        .IsRequired()
        .HasMaxLength(80);
      modelBuilder.Entity<User>()
        .Property(u => u.Email)
        .IsRequired()
        .HasMaxLength(255);

    }

  }
}