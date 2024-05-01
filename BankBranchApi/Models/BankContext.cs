using Microsoft.EntityFrameworkCore;

namespace BankBranchApi.Models
{
    public class BankContext : DbContext
    {
        public DbSet<BankBranchModel> BankBranches { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public BankContext(DbContextOptions<BankContext> options) : base(options) { }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=bank.db");
                base.OnConfiguring(optionsBuilder);
            }
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmployeeModel>().HasIndex(r => r.CivilId).IsUnique();
        }
    }
}
