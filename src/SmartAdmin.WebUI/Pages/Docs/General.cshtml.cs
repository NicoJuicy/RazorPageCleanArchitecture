using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Docs
{
    public class GeneralModel : PageModel
    {
        private readonly ILogger<GeneralModel> _logger;

        public GeneralModel(ILogger<GeneralModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
