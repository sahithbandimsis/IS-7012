public class Industry
{
    public int Id { get; set; }  // Unique ID for each industry
    public string Name { get; set; }  // Industry name

    // Relationships
    public ICollection<Company> Companies { get; set; }
    public ICollection<Candidate> Candidates { get; set; }
}
