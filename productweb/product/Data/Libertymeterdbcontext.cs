using Microsoft.EntityFrameworkCore;
using product.Models;

namespace product.Data;

    public class Libertymeterdbcontext : DbContext
    {
        public Libertymeterdbcontext(DbContextOptions<Libertymeterdbcontext> Options) : base(Options)
        {

        }
        public DbSet<Product> liberty { get; set; }
    }

