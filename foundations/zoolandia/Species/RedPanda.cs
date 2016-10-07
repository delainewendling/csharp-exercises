using Zoolandia.Genuses;

namespace Zoolandia.Species
{
  public class RedPanda:Ursid
  {
    public RedPanda(string name)
    {
      this.speciesName = "Ailurus fulgens";
      this.commonName = "Red Panda";
      this.name = name;
    }
    public string extinction{get; set;}
    public int numberOfBambooStalks{get; set;}

    public override string animalMessage()
    {
      return $"{base.animalMessage()} More facts about your animal:\n - {this.weirdFact} \n - A red panda can run up to a surprising {this.run(this.speed)}. \n - Red pandas sleep {this.avgSleep(this.hours, this.sleepLocation)}\n - {this.extinction} \n Oh, don't forget he eats {this.numberOfBambooStalks} bamboo stalks for every meal, and he has a lot of meals!";
    } 

  }
}