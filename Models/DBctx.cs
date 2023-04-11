using Microsoft.EntityFrameworkCore;

namespace Centrifuge.Models;

public class LocalDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Tag> Tags { get; set; }

    private static readonly string connectionString =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Centrifuge",
            "local.db"
        );

    public LocalDbContext()
    {
        if (!File.Exists(connectionString) && connectionString != null)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(connectionString));
            File.Create(connectionString).Close();
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={connectionString}");
    }
}

