using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    // [Route("/goodbye")]
    // public string Goodbye() { return "Goodbye friend."; }

    // [Route("/")]
    // public ActionResult Letter() 
    // {
    //   LetterVariable myLetterVariable = new LetterVariable();
    //   myLetterVariable.Recipient = "Lina";
    //   myLetterVariable.Sender = "Jasmine";
    //   return View(myLetterVariable);
    // }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/page")]
    public ActionResult Page() { return View(); }

    [Route("/madlibsoutput")]
    public ActionResult Madlibsoutput(string adjective, string adjective1, string adjective2, string adjective3, string noun, string noun1, string noun2, string verb, string verb1, string verb2, string adverb, string adverb1)
    {
      MadLibsVariables myMadLibsVars = new MadLibsVariables();
      myMadLibsVars.Adjective = adjective;
      myMadLibsVars.Adjective1 = adjective1;
      myMadLibsVars.Adjective2 = adjective2;
      myMadLibsVars.Adjective3 = adjective3;
      myMadLibsVars.Noun = noun;
      myMadLibsVars.Noun1 = noun1;
      myMadLibsVars.Noun2 = noun2;
      myMadLibsVars.Verb = verb;
      myMadLibsVars.Verb1 = verb1;
      myMadLibsVars.Verb2 = verb2;
      myMadLibsVars.Adverb = adverb;
      myMadLibsVars.Adverb1 = adverb1;
      return View(myMadLibsVars);
    }

    [Route("/madlibsoutput2")]
    public ActionResult Madlibsoutput2(string adjective, string noun, string verb)
    {
      MadLibsVariables myMadLibsVars = new MadLibsVariables();
      myMadLibsVars.Adjective = adjective;
      myMadLibsVars.Noun = noun;
      myMadLibsVars.Verb = verb;

      return View(myMadLibsVars);
    }

  }
}