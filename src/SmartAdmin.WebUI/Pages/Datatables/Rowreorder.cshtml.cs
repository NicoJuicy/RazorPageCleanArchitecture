using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Datatables
{
    public class RowreorderModel : PageModel
    {
        private readonly ILogger<RowreorderModel> _logger;

        public RowreorderModel(ILogger<RowreorderModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
