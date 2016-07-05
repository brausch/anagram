using System;
using System.Collections.Generic;

namespace Anagram
{
  public class Anagram
  {
    private string _word;
    private static List<string> _words  = new List<string> {};

    public Anagram(string word, List<string> words)
    {
      _word = word;
      _words = words;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }
    // public List<string> GetWords()
    // {
    //   return _words;
    // }
    // public void SetWords(string newWords)
    // {
    //   _words = newWords;
    // }
    public static List<string> GetAll()
    {
      return _words;
    }

    public List<string> GetAnagram()
    {
      List<string> result = new List<string>{};
      char[] wordArray = _word.ToCharArray();
      Array.Sort(wordArray);
      string comparedWord = string.Join("", wordArray);
      foreach(string a in _words)
      {
        char[] aArray = a.ToCharArray();
        Array.Sort(aArray);
        if(string.Join("", aArray) == comparedWord){
          result.Add(a);
        }
      }
      return result;
    }
  }
}
