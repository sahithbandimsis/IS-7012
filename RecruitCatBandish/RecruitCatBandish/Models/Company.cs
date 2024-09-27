using System.ComponentModel.DataAnnotations;

public class Company
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Company Name cannot be longer than 100 characters.")]
    [Display(Name = "Company Name")]
    public string? Name { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Position Name cannot be longer than 100 characters.")]
    [Display(Name = "Position Name")]
    public string? PositionName { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Minimum Salary must be a positive value.")]
    [Display(Name = "Minimum Salary")]
    public decimal MinSalary { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Maximum Salary must be a positive value.")]
    [Display(Name = "Maximum Salary")]
    public decimal MaxSalary { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Start Date")]
    public DateTime? StartDate { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Location cannot be longer than 100 characters.")]
    [Display(Name = "Company Location")]
    public string Location { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Employee Count must be a positive value.")]
    [Display(Name = "Number of Employees")]
    public int EmployeeCount { get; set; }

    [Url(ErrorMessage = "Invalid URL")]
    [Display(Name = "Website URL")]
    public string Website { get; set; }

    // Relationships
    [Required]
    [Display(Name = "Industry")]
    public int IndustryId { get; set; }
    public Industry? Industry { get; set; }

    public List<Candidate>? Candidates { get; set; }
}

