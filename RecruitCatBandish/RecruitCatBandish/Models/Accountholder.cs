namespace RecruitCatBandish.Models
{
    public class AccountHolder
    {
        public int Id { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AccHolAddress { get; set; }
        public string PhoneNumber { get; set; }

        // Navigation property
        public BankAccount? BankAccount { get; set; }
    }
}