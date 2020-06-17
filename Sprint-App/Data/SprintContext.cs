using Microsoft.EntityFrameworkCore;
using Sprint.Models;

namespace Sprint.Data
{
    public class SprintContext : DbContext
    {
        public SprintContext(DbContextOptions<SprintContext> options) : base(options)
        {
      
        }

        public DbSet<Board> Board { get; set; }
    }
}
