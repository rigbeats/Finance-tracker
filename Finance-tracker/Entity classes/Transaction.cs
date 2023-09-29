using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_tracker.Entity_classes
{
    public class Transaction
    {
        public int Id { get; set; }

        public int CardId { get; set; }

        public decimal Amount { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        public string Number { get; set; }

        public virtual Card Card { get; set; }
    }
}
