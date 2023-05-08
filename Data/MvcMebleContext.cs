using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcMebleContext : DbContext
    {
        public MvcMebleContext(DbContextOptions<MvcMebleContext> options)
        : base(options)
        {
        }
        public DbSet<Meble> Meble { get; set; }
    }
}
