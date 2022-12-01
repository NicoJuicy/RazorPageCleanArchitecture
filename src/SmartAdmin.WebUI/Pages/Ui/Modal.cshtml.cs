using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartAdmin.WebUI.Pages.Ui
{
    public class ModalModel : PageModel
    {
        private readonly ILogger<ModalModel> _logger;

        public ModalModel(ILogger<ModalModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
