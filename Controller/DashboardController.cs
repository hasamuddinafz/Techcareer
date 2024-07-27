using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers{
    public class DashboardController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}