using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MvcMovie.Views.HelloWorld
{
    public class Welcome : PageModel
    {
        private readonly ILogger<Welcome> _logger;

        public Welcome(ILogger<Welcome> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}