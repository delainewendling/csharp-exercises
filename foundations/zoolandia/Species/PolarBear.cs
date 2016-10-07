using Zoolandia.Genuses;

namespace Zoolandia.Species
{
  public class PolarBear:Ursid
  {
    public PolarBear(string name)
    {
      this.speciesName = "Ursus maritimus";
      this.name = name;
    }
    public string attack {get; set;}

    public override string animalMessage()
    {
      return $"{base.animalMessage()} More facts about your animal:\n - {this.weirdFact}\n- A polar bear can run up to {this.run(this.speed)}.\n - Polar Bears sleep {this.avgSleep(this.hours)} \n Oh, don't forget {this.attack}";
    } 

  }
}