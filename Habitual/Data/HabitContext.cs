using Habitual.Models;
using Microsoft.EntityFrameworkCore;

namespace Habitual.Data
{
    public class HabitContext : DbContext
    {
        public DbSet<Value> Values { get; set; }
        
        public HabitContext(DbContextOptions<HabitContext> options) : base(options){}
    }
}