using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Datatables
{
    public class ColumnfilterModel : PageModel
    {
        private readonly ILogger<ColumnfilterModel> _logger;

        public ColumnfilterModel(ILogger<ColumnfilterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
