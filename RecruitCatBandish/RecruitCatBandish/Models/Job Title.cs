public class JobTitle
{
    public int Id { get; set; }  // Unique ID for each job title
    public string Title { get; set; }  // Job title name
    public decimal MinSalary { get; set; }  // Minimum salary for the job title
    public decimal MaxSalary { get; set; }  // Maximum salary for the job title

    // Relationships
    public ICollection<Candidate> Candidates { get; set; }
}
