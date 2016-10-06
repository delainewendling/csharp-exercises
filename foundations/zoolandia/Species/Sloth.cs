using System;
using Zoolandia.Animals;

namespace Zoolandia.Species
{
  class Sloth:Animal
  {
    public Sloth()
    {
      this.speciesName = "Folivora";
    }

    public int toeNumber{get; set;}

    public override string animalMessage()
    {
      return $"{base.animalMessage()} Just to clarify, he's a {this.toeNumber} toed sloth. There's a difference, look it up!";
    } 

  }
}