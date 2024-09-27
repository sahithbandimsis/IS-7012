using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatBandish.Models
{
    public class AccountHolder
    {
        public int Id { get; set; } // Primary Key


        [DisplayName("First Name")]
        [Required(ErrorMessage = "enter your first name is mandatory")]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        [StringLength(20,MinimumLength =3)]
        public string LastName { get; set; }


        [DisplayName("Date of Birth")]
        [Required(ErrorMessage ="enter your date of birth for us to check if you are above 18 years")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


        [DisplayName("Account Holder Address")]
        public string AccHolAddress { get; set; }


        [DisplayName("Phone Number")]
        [Phone ]
        public string PhoneNumber { get; set; }

        // Navigation property
        public List<BankAccount>? BankAccount { get; set; }
    }
}