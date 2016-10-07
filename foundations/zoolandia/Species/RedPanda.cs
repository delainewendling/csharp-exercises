using Zoolandia.Genuses;

namespace Zoolandia.Species
{
  public class RedPanda:Ursid
  {
    public RedPanda(string name)
    {
      this.speciesName = "Ailurus fulgens";
      this.name = name;
    }
    public int numberOfBambooStalks{get; set;}

    public override string animalMessage()
    {
      return $"{base.animalMessage()} Oh, don't forget he eats {this.numberOfBambooStalks} bamboo stalks for every meal!";
    } 

  }
}