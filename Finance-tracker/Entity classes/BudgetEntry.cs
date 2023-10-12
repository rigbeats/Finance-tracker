using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_tracker.Entity_classes
{
    public class BudgetEntry
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime Date {  get; set; } 
    }
}
