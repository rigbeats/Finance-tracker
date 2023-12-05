using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Finance_tracker.Entity_classes
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int DefaultCardId { get; set; }

        public virtual UserData UserData { get; set; }

        public virtual ICollection<Card> Cards { get; set; }

        public User()
        {
            UserData = new UserData(); // Set a default UserData when creating a new User
        }
    }
}