using Microsoft.EntityFrameworkCore;
using product.Models;

namespace product.Data;

    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options)  : base(Options)
        {

        }
    public DbSet<Product> liberty { get; set; }
    }

