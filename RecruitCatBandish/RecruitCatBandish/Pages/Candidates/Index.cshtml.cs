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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBandish.Data.RecruitCatBandishContext _context;

        public IndexModel(RecruitCatBandish.Data.RecruitCatBandishContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
