public class Company
{
    public int Id { get; set; }  // Unique ID for each company
    public string Name { get; set; }  // Company name
    public string PositionName { get; set; }  // Name of the position the company is recruiting for
    public decimal MinSalary { get; set; }  // Minimum salary for the position
    public decimal MaxSalary { get; set; }  // Maximum salary for the position
    public DateTime? StartDate { get; set; }  // Optional start date
    public string Location { get; set; }  // Company location

    // Additional Properties
    public int EmployeeCount { get; set; }  // Number of employees (additional)
    public string Website { get; set; }  // Company's website (additional)

    // Relationships
    public ICollection<Candidate> Candidates { get; set; }
    public int IndustryId { get; set; }
    public Industry Industry { get; set; }
}
