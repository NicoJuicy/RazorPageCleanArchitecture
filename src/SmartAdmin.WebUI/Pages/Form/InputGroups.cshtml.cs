using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Form
{
    public class InputGroupsModel : PageModel
    {
        private readonly ILogger<InputGroupsModel> _logger;

        public InputGroupsModel(ILogger<InputGroupsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
