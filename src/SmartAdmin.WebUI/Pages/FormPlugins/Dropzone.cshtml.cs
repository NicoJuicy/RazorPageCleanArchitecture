using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.FormPlugins
{
    public class DropzoneModel : PageModel
    {
        private readonly ILogger<DropzoneModel> _logger;

        public DropzoneModel(ILogger<DropzoneModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
