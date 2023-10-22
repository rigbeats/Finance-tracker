using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_tracker.Entity_classes
{
    public class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int DefaultCardId { get; set; }

        public virtual UserData userId { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
