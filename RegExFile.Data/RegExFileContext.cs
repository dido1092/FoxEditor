using Microsoft.EntityFrameworkCore;
using RegExFile.Common;
using RegExFile.Data.Models;

namespace RegExFile.Data
{
    public class RegExFileContext :DbContext 
    {
        public DbSet<BgWords>? BgWords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Sett default connection string
                // Someone used empty constructor of our DbContext
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
                optionsBuilder.EnableSensitiveDataLogging();

            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
