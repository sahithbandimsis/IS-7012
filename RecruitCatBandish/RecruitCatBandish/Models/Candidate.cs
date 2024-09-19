using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

public class Candidate
{
    public int Id { get; set; }  // Unique ID for each candidate
    public string FirstName { get; set; }  // Candidate's first name
    public string LastName { get; set; }  // Candidate's last name
    public decimal TargetSalary { get; set; }  // Candidate's target salary
    public DateTime? StartDate { get; set; }  // Optional start date

    // optional Properties
    public string Email { get; set; }  // Candidate's email address (optional)
    public string PhoneNumber { get; set; }  // Candidate's phone number (optional)
    public bool IsActive { get; set; }  // Candidate's active status (optional)

    // Relationships
    public int JobTitleId { get; set; }
    public JobTitle JobTitle { get; set; }
    public int? CompanyId { get; set; }  // Nullable since a candidate can have zero companies
    public Company Company { get; set; }
    public int IndustryId { get; set; }
    public Industry Industry { get; set; }
}
