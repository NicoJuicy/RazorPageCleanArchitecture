using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.FormPlugins
{
    public class SummernoteModel : PageModel
    {
        private readonly ILogger<SummernoteModel> _logger;

        public SummernoteModel(ILogger<SummernoteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
