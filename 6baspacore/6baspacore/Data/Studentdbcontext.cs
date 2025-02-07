using _6baspacore.Models;
using Microsoft.EntityFrameworkCore;

namespace _6baspacore.Data
{
    public class Studentdbcontext:DbContext
    {
      public Studentdbcontext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Studentmodel> StudentRegister { get; set; }//always model name enter

    }
}
