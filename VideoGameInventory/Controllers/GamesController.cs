using Microsoft.AspNetCore.Mvc;
using VideoGameInventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace VideoGameInventory.Controllers
{
  public class GamesController : Controller
  {
    private readonly VideoGameInventoryContext _db;

    public GamesController(VideoGameInventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Game> model = _db.Items.ToList();
      return View(model);
    }
  }
}