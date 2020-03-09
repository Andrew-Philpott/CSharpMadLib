using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }

    [Route("/result")]
    public ActionResult Result(string firstName, string lastName, string storyType)
    {
      MadLibGame myGame = new MadLibGame(firstName, lastName);
      myGame.FirstName = firstName;
      myGame.LastName = lastName;

      switch (storyType.ToLower())
      {
          case "horror":
          return View("Horror", myGame);
          case "funny":
          return View("Funny", myGame);
          case "history":
          return View("History", myGame);
          default:
          return View("Index");
      }
    }

    [Route("/horror")]
    public ActionResult Horror(MadLibGame game)
    {
      return View(game);
    }

    [Route("/funny")]
    public ActionResult Funny(MadLibGame game)
    {
      return View(game);
    }

    [Route("/history")]
    public ActionResult History(MadLibGame game)
    {
      return View(game);
    }
  
  [Route("/aboutus")]
    public ActionResult AboutUs() 
    { 
      return View(); 
    }
  }
}