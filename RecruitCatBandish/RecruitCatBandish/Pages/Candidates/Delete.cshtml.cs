using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBandish.Data;

namespace RecruitCatBandish.Pages.Candidates
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatBandish.Data.RecruitCatBandishContext _context;

        public DeleteModel(RecruitCatBandish.Data.RecruitCatBandishContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.Include(j => j.JobTitle)
                                                    .Include(i => i.Industry)
                                                    .Include(c => c.Company).FirstOrDefaultAsync(m => m.Id == id);

            if (candidate == null)
            {
                return NotFound();
            }
            else
            {
                Candidate = candidate;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FindAsync(id);
            if (candidate != null)
            {
                Candidate = candidate;
                _context.Candidate.Remove(Candidate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
