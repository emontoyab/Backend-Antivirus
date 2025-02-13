using Microsoft.EntityFrameworkCore;
using Antivirus.Models;

namespace Antivirus.Data
{
    public class AntivirusContext : DbContext
    {
        public AntivirusContext(DbContextOptions<AntivirusContext> options)
            : base(options)
        {
        }

        public DbSet<categories_opportunities> CategoriesOpportunities { get; set; }
    }
}
