using DesafioDotNET.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioDotNET.Data.DatabaseContext
{
    public sealed class ApplicationDbContext : DbContext
    {
        public DbSet<KeyPix> Keys { get; set; }
        public DbSet<Payer> Payers { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<TransactionPix> Transactions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
        {
            ChangeTracker.LazyLoadingEnabled = true;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }



    }
}

