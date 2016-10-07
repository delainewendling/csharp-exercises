using Zoolandia.Animals;

namespace Zoolandia.Genuses
{
  public class Giraffa: Animal 
  {
    public string region {get; set;}
    public override string animalMessage()
    {
      return $"{base.animalMessage()} More facts about your animal: \n - {this.weirdFact} \n - They only sleep {this.avgSleep(this.hours)}\n - Giraffes can run up to {this.run(this.speed, this.reasonForRunning)}\n";
    }
  }
}