using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string firstName, string lastName, string storyType)
    {
      MadLibGame myGame = new MadLibGame(firstName, lastName);
      myGame.FirstName = firstName;
      myGame.LastName = lastName;

      switch (storyType)
      {
          case "horror":
          return View("horror", myGame);
          case "funny":
          return View("funny", myGame);
          case "history":
          return View("history", myGame);
          default:
          return View("form");
      }
    }

    [Route("/horror")]
     public ActionResult Result(MadLibGame game)
    {
      // MadLibGame myGame = new MadLibGame(firstName, lastName, dateOfBirth);
      // myGame.FirstName = firstName;
      // myGame.LastName = lastName;
      // myGame.DateOfBirth = dateOfBirth;

      return View(game);
    }

    [Route("/funny")]
     public ActionResult Result(MadLibGame game)
    {
      // MadLibGame myGame = new MadLibGame(firstName, lastName, dateOfBirth);
      // myGame.FirstName = firstName;
      // myGame.LastName = lastName;
      // myGame.DateOfBirth = dateOfBirth;

      return View(game);
    }

    [Route("/history")]
     public ActionResult Result(MadLibGame game)
    {
      // MadLibGame myGame = new MadLibGame(firstName, lastName, dateOfBirth);
      // myGame.FirstName = firstName;
      // myGame.LastName = lastName;
      // myGame.DateOfBirth = dateOfBirth;

      return View(game);
    }
  }
}