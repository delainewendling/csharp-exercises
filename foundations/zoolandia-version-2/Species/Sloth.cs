using Zoolandia.Genuses;

namespace Zoolandia.Species
{
  public class Sloth:Bradypus
  {
    public Sloth(string name)
    {
      this.speciesName = "Folivora";
      this.commonName = "Sloth";
      this.name = name;
    }
    public int toeNumber{get; set;}

    public override string animalMessage()
    {
      return $"{base.animalMessage()} \n Lastly (just to clarify) he's a {this.toeNumber} toed sloth. There's a difference, look it up!";
    } 

  }
}