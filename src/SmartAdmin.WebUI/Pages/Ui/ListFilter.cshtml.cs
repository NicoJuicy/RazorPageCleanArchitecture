using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Ui
{
    public class ListFilterModel : PageModel
    {
        private readonly ILogger<ListFilterModel> _logger;

        public ListFilterModel(ILogger<ListFilterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
