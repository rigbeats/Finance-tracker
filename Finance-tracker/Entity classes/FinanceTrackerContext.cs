using System.Data.Entity;

namespace Finance_tracker.Entity_classes
{
    public class FinanceTrackerContext : DbContext
    {
        public FinanceTrackerContext() : base("FinanceTrackerConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserData> UserData { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BudgetEntry> BudgetEntries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOptional(u => u.UserData)
                .WithRequired(ud => ud.User);
        }
    }
}
