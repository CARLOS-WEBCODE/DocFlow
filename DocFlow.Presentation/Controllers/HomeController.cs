using Microsoft.AspNetCore.Mvc;

namespace DocFlow.Presentation.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
