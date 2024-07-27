using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers{
    public class AdminContactController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}