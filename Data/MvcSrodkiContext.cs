using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcSrodkiContext : DbContext
    {
        public MvcSrodkiContext(DbContextOptions<MvcSrodkiContext> options)
        : base(options)
        {
        }
        public DbSet<Srodki> Srodki { get; set; }
    }
}
