using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Datatables
{
    public class RowgroupModel : PageModel
    {
        private readonly ILogger<RowgroupModel> _logger;

        public RowgroupModel(ILogger<RowgroupModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
