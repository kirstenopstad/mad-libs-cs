using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string holiday, string action, string name) {
      // takes user inputs as args
      // defines in variable instance
      StoryVariable storyVariable = new StoryVariable();
      storyVariable.Holiday = holiday;
      storyVariable.Action = action;
      storyVariable.Name = name;
      // return View taking instantiated variable as arg
      return View(storyVariable);
    }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/story2")]
    public ActionResult Story2(string gettysburg, string inputtedEvent) {
      // takes user inputs as args
      // defines in variable instance
      StoryVariable storyVariable = new StoryVariable();
      storyVariable.Gettysburg = gettysburg;
      storyVariable.InputtedEvent = inputtedEvent;
      // return View taking instantiated variable as arg
      return View(storyVariable);
    }
  }
  
}