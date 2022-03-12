using Microsoft.EntityFrameworkCore;

namespace Asp.netCorePortfolio;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
            
    }
}