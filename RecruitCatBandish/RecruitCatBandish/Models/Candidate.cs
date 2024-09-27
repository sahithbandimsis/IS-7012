using System.ComponentModel.DataAnnotations;

public class Candidate
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Target Salary must be a positive value.")]
    [Display(Name = "Target Salary")]
    public decimal TargetSalary { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Start Date")]
    public DateTime? StartDate { get; set; }

    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Phone(ErrorMessage = "Invalid Phone Number")]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Display(Name = "Is Active")]
    public bool IsActive { get; set; }

    // Relationships
    [Required]
    [Display(Name = "Job Title")]
    public int JobTitleId { get; set; }
    public JobTitle? JobTitle { get; set; }

    [Display(Name = "Company")]
    public int CompanyId { get; set; }
    public Company? Company { get; set; }

    [Required]
    [Display(Name = "Industry")]
    public int IndustryId { get; set; }
    public Industry? Industry { get; set; }
}