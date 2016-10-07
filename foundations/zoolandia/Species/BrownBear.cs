using Zoolandia.Genuses;

namespace Zoolandia.Species
{
  public class BrownBear:Ursid
  {
    public BrownBear(string name)
    {
      this.speciesName = "Ursus arctos";
      this.commonName = "Brown Bear";
      this.name = name;
    }

    public override string animalMessage()
    {
      return $"{base.animalMessage()} ";
    } 

  }
}