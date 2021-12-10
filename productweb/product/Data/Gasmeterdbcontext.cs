using Microsoft.EntityFrameworkCore;
using product.Models;

namespace product.Data;

    public class Gasmeterdbcontext : DbContext
{    
    public Gasmeterdbcontext(DbContextOptions<Gasmeterdbcontext> Options) : base(Options)
    {

    }
    public DbSet<Product> liberty { get; set; }
}       



