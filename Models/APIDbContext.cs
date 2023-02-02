using Microsoft.EntityFrameworkCore;

namespace First_Web_API_CORE.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options ):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }    
    }
}
