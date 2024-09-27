using System.ComponentModel.DataAnnotations;

public class JobTitle
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Job Title cannot be longer than 100 characters.")]
    [Display(Name = "Job Title")]
    public string Title { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Minimum Salary must be a positive value.")]
    [Display(Name = "Minimum Salary")]
    public decimal MinSalary { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Maximum Salary must be a positive value.")]
    [Display(Name = "Maximum Salary")]
    public decimal MaxSalary { get; set; }

    // Relationships
    public List<Candidate>? Candidates { get; set; }
}
