using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Core_HelloWorld.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            this.Message = "This is my First ASP.Net Core 2.1 Razor Page App.";
        }
    }
}