using Microsoft.EntityFrameworkCore;

namespace VideoGameInventory.Models
{
  public class VideoGameInventoryContext : DbContext
  {
    public DbSet<Game> Games { get; set; }

    public VideoGameInventoryContext(DbContextOptions options) : base(options) { }
  }
}