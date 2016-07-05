using Nancy;
using System.Collections.Generic;
using Anagram;

namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/anagram"] = _ => {
        List<string> newList = new List<string>{Request.Query["word1"], Request.Query["word2"], Request.Query["word3"], Request.Query["word4"], Request.Query["word5"]};
        Anagram newAnagram = new Anagram(
        Request.Query["anagram"], newList);
        List<string> newList2 = newAnagram.GetAnagram();
        return View["anagram.cshtml", newList2];
      };
    }
  }
}
