using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SvelteTest2.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public string PassIn = "Passing information into the component.";

        public void OnGet() {
            ViewData["PassInJson"] = System.Text.Json.JsonSerializer.Serialize(PassIn);
        }
    }
}
