using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_phani.Pages
{
    public class DeploymentSlotsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration configuration;

        public DeploymentSlotsModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }
        public void OnGet()
        {
            ViewData["Greetings"] = this.configuration["Greetings"];
        }
    }
}
