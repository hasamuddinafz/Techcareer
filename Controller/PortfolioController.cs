using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers{
    public class PortfolioController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}