using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers{
    public class DetailController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}