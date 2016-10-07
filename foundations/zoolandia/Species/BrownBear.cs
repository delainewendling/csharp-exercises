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
    public string hibernation{ get; set; }
    public override string avgSleep(int hours)
    {
      return $"When brown bears are getting ready for hibernation they sleep {hours} hours per day. When hibernating, the bears are dormant throughout the day";
    }
    public override string animalMessage()
    {
      return $"{base.animalMessage()} More facts about your animal:\n - {this.weirdFact}\n- A brown bear can run up to {this.run(this.speed)}.\n - {this.avgSleep(this.hours)} \n - {this.hibernation}";
    } 

  }
}