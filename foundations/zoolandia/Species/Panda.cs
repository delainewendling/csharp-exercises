using System;
using Zoolandia.Animals;

namespace Zoolandia.Species
{
  class Panda:Animal
  {
    public Panda(string name)
    {
      this.speciesName = "Ailuropoda melanoleuca";
      this.name = name;
    }

    public int numberOfBambooStalks{get; set;}

    public override string animalMessage()
    {
      return $"{base.animalMessage()} Oh, don't forget he eats {this.numberOfBambooStalks} bamboo stalks for every meal!";
    } 

  }
}