using Microsoft.EntityFrameworkCore;

namespace RegExFile
{
    public class RegExFileContext :DbContext 
    {
        public DbSet<BgWords> BgWords { get; set; }
        public DbSet<EnWords> EnWords { get; set; }
        public DbSet<EnWordsTranscript> EnWordsTranscript { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Sett default connection string
                optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
