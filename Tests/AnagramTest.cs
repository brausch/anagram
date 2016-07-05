using Xunit;
using System.Collections.Generic;

namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void anagram_true()
    {
      List<string> testWords = new List<string>{"llohe","Cherio", "heoll"};

      //"llohe","Cherio", "heoll"
      Anagram test = new Anagram("hello",testWords);
      Assert.Equal("heoll", test.GetAnagram()[1]);
    }
  }
}
