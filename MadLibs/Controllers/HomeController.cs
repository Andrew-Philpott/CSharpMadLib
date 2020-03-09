using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string name, string lastName)
    {
      MadLibGame myGame = new MadLibGame();
      myGame.Name = name;
      myGame.LastName = lastName;

      return View(myGame);
    }    
  }
}