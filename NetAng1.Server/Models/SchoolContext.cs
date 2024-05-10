using Microsoft.EntityFrameworkCore;

namespace NetAng1.Server.Models
{
    public class SchoolContext(IConfiguration configuration) : DbContext
    {   
        protected readonly IConfiguration Configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DatabaseOptions"));
        }
        public DbSet<Student> Students { get; set; }
    }
}
