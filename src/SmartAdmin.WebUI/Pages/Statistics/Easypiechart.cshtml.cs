using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Statistics
{
    public class EasypiechartModel : PageModel
    {
        private readonly ILogger<EasypiechartModel> _logger;

        public EasypiechartModel(ILogger<EasypiechartModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
