using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finance_tracker.Entity_classes
{
    [Table("UserData")]
    public class UserData
    {
        [Key, ForeignKey("User")]
        public int UserDataId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public virtual User User { get; set; }
    }
}
