using System.Collections.Generic;

namespace Finance_tracker.Entity_classes
{
    public class Card
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string HolderFullName { get; set; }

        public string ValidThru { get; set; }

        public decimal Balance { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
