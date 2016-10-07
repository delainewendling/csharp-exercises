using Zoolandia.Animals;

namespace Zoolandia.Genuses
{
  public class Bradypus: Animal 
  {
   public override string animalMessage()
    {
      return $"{base.animalMessage()} More facts about your animal: \n - {this.weirdFact} \n - Researchers in Germany found out that sloths do not sleep as much as previously thought. They only sleep {this.avgSleep(this.hours, this.sleepLocation)}\n - Sloths can run at a blinding speed of {this.run(this.speed)}";
    }
  }
}