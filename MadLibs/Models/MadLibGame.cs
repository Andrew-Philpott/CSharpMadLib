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
    public string RandomAge {get; set;}

   public MadLibGame(string firstName, string lastName){

    FirstName = firstName;
    LastName = lastName;
   }

  public string GetRandomAge(){
    Random random = new Random();
    int randomAgeNumber = random.Next(0, 100);
    string randomAge = Verbs[randomVerbNumber];
    return randomAge;
  }
   
   public string GetRandomVerb(){
    Random random = new Random();
    int randomVerbNumber = random.Next(0, Verbs.Length-1);
    string randomVerb = Verbs[randomVerbNumber];
    return randomVerb;
   }
   public string GetRandomNoun(){
    Random random = new Random();
    int randomNounNumber = random.Next(0, Nouns.Length-1);
    RandomNoun = Nouns[randomNounNumber];
    return RandomNoun;
   }
   public string GetRandomVerb(){
    Random random = new Random();
    int randomAdverbNumber = random.Next(0, Adverbs.Length-1);
    RandomAdverb = Adverbs[randomAdverbNumber];
    return RandomAdverb;
   }
  }
}
    