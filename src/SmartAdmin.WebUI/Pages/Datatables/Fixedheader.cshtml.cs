using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Datatables
{
    public class FixedheaderModel : PageModel
    {
        private readonly ILogger<FixedheaderModel> _logger;

        public FixedheaderModel(ILogger<FixedheaderModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
