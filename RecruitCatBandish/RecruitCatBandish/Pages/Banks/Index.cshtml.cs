using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBandish.Data;
using RecruitCatBandish.Models;

namespace RecruitCatBandish.Pages.Banks
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBandish.Data.RecruitCatBandishContext _context;

        public IndexModel(RecruitCatBandish.Data.RecruitCatBandishContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount
                .Include(b => b.AccountHolder).ToListAsync();
        }
    }
}
