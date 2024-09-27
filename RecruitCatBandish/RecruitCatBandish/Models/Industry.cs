using System.ComponentModel.DataAnnotations;

public class Industry
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Industry Name cannot be longer than 100 characters.")]
    [Display(Name = "Industry Name")]
    public string Name { get; set; }

    // Relationships
    public List<Company>? Company { get; set; }
    public List<Candidate>? Candidates { get; set; }
}
