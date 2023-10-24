using System;
using System.Collections.Generic;
using System.Data.Entity;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_tracker.Entity_classes
{
    public class FinanceTrackerContext : DbContext
    {
        /*public FinanceTrackerContext() : base("FinanceTrackerConnection")
        {
        }*/

        public DbSet<User> Users { get; set; }
        public DbSet<UserData> UserData { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BudgetEntry> BudgetEntries { get; set; }
    }
}
