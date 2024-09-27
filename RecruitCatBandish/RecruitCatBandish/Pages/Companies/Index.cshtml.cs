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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBandish.Data.RecruitCatBandishContext _context;

        public IndexModel(RecruitCatBandish.Data.RecruitCatBandishContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
