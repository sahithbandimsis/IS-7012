namespace RecruitCatBandish.Models
{
    public class BankAccount
    {
        public int BankAccountID { get; set; } // Primary Key
        public decimal? CurrentBalance { get; set; }
        public string? AccountName { get; set; }
        public string? AccountType { get; set; }

        // Foreign Key to AccountHolder
        public int? AccountHolderId { get; set; } // Foreign Key

        // Navigation property
        public AccountHolder? AccountHolder { get; set; }
    }
}