using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string holiday) {
      // takes user inputs as args
      // defines in variable instance
      StoryVariable storyVariable = new StoryVariable();
      storyVariable.Holiday = holiday;
      // return View taking instantiated variable as arg
      return View(storyVariable);
    }
  }
  
}