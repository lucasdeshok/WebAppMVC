using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using senac_sjrp.Models;

namespace senac_sjrp.Repository
{
    public class SenacContext : DbContext
    {

        public DbSet<Pie> Pies { get; set; }
        public DbSet<User> Users { get; set; }

        public SenacContext(DbContextOptions<SenacContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            ILoggerFactory factory = LoggerFactory.Create(l => l.AddConsole());
            optionsBuilder.UseLoggerFactory(factory);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PieMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}