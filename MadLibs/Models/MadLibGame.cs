using System;

namespace MadLibs.Models
{
  public class MadLibGame
  {

    public string[] Verbs = new string[] {"ran", "stumbled", "apologized", "admired", "adapted"};
    public string[] Adverbs = new string[] {"madly", "cheerfully", "nervously", "foolishly"};
    public string [] Nouns = new string[] {"area", "book", "business", "case", "child", "company", "country", "day", "eye", "fact", "family", "government", "group", "hand", "home", "job", "life", "lot", "man", "money", "month", "mother", "night", "number", "part", "people", "place", "point", "problem", "program", "question", "right", "room", "school", "state", "story", "student", "study", "system", "thing", "time", "water", "way", "week", "woman", "word", "work", "world", "year"};

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth {get;set;}
    
    public string RandomVerb {get;set;}

    public string RandomAdverb {get;set;}

    public string RandomNoun {get;set;}


   public MadLibGame(string firstName, string lastName, string dateOfBirth){

    FirstName = firstName;
    LastName = lastName;
    DateOfBirth = dateOfBirth;

    Random random = new Random();
    int randomVerbNumber = random.Next(0, Verbs.Length-1);
    RandomVerb = Verbs[randomVerbNumber];
    int randomNounNumber = random.Next(0, Nouns.Length-1);
    RandomNoun = Nouns[randomNounNumber];
    int randomAdverbNumber = random.Next(0, Adverbs.Length-1);
    RandomAdverb = Adverbs[randomAdverbNumber];
   }
  }
}
    