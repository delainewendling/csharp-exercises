namespace Zoolandia.Habitats
{
public class Jungle : Habitat, IJungleHabitat
  {
      public Jungle (string name, double cageTemperature)
      {
          this.temperature = cageTemperature;
          this.publicname = name;
      }
  }
}