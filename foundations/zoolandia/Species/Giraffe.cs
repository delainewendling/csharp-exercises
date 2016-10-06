using System;
using Zoolandia.Animals;

namespace Zoolandia.Species
{
  public class Giraffe:Animal
  {
    public Giraffe(string name)
    {
      this.speciesName = "Giraffa camelopardalis";
      this.name = name;
    }
    public string neckLength{ get; set; }

    public override string animalMessage()
    {
      return $"{base.animalMessage()} Oh, don't forget his neck is {this.neckLength} long! Whoa!";
    } 

  }
}
