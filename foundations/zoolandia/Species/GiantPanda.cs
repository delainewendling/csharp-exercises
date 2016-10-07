using Zoolandia.Genuses;

namespace Zoolandia.Species
{
  public class GiantPanda:Ursid
  {
    public GiantPanda(string name)
    {
      this.speciesName = "Ailuropoda melanoleuca";
      this.commonName = "Giant Panda";
      this.name = name;
    }

    public int numberOfBambooStalks{get; set;}

    public override string animalMessage()
    {
      return $"{base.animalMessage()} More facts about your animal:\n - {this.weirdFact} \n - A giant panda can run {this.run(this.speed)}. \n - Giant pandas sleep {this.avgSleep(this.hours)} \n Oh, don't forget he eats {this.numberOfBambooStalks} bamboo stalks for every meal, and he has a lot of meals!";
    } 

  }
}