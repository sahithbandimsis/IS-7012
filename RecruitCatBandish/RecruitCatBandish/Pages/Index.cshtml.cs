using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecruitCatBandish.Pages
{
    public class OurTeamModel : PageModel
    {
        private readonly ILogger<OurTeamModel> _logger;

        public OurTeamModel(ILogger<OurTeamModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
