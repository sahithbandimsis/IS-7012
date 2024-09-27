using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBandish.Data;

namespace RecruitCatBandish.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatBandish.Data.RecruitCatBandishContext _context;

        public DetailsModel(RecruitCatBandish.Data.RecruitCatBandishContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Query to get the company and include related candidates
            Company = await _context.Company
                .Include(c => c.Candidates) // Eager load related candidates
                .ThenInclude(c => c.JobTitle) // Optionally include JobTitle of each candidate
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }

            // Set the list of candidates for use in the view
            Candidates = Company.Candidates.ToList();

            return Page();
        }
    }
}
