using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}