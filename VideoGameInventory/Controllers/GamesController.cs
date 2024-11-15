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
      List<Game> model = _db.Games.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Game game)
    {
      _db.Games.Add(game);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Game thisGame = _db.Games.FirstOrDefault(game => game.GameId == id);
      return View(thisGame);
    }
  }
}