using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers{
    public class AddPostController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}