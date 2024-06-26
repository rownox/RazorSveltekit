using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SvelteTest2.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public List<Item> Items { get; set; }

        public void OnGet() {
            Items = new List<Item>
            {
                new Item { Name = "John Doe", Age = 30, Location = "New York" },
                new Item { Name = "Jane Smith", Age = 25, Location = "San Francisco" }
            };
        }

        public class Item {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Location { get; set; }
        }
    }
}
