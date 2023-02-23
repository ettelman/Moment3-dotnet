using Microsoft.EntityFrameworkCore;
using Moment3_dotnet.Models;

namespace moment3.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cd> Cd { get; set; }

        public DbSet<Artist> Artist { get; set; }
    }
}