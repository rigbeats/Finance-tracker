using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_tracker.Entity_classes
{
    public class Card
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string HolderName { get; set; }

        public string HolderSurname { get; set; }

        public string ValidThru { get; set; }

        public string Balance { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
