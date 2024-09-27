using System.ComponentModel;

namespace RecruitCatBandish.Models
{
    public class BankAccount
    {
        public int BankAccountID { get; set; } // Primary Key

        [DisplayName("Balance in Account")]
        public decimal? CurrentBalance { get; set; }

        [DisplayName("Account Holder Name")]
        public string? AccountName { get; set; }

        [DisplayName("Type of Account")]
        public string? AccountType { get; set; }

        // Foreign Key to AccountHolder
        public int? AccountHolderId { get; set; } // Foreign Key

        // Navigation property
        public AccountHolder? AccountHolder { get; set; }
    }
}