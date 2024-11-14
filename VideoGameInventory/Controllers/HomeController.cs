using Microsoft.AspNetCore.Mvc;

namespace VideoGameInventory.Models
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}