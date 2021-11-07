using Microsoft.AspNetCore.Mvc;

namespace Login2.Controllers
{
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}