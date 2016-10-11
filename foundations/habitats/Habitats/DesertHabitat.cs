namespace Zoolandia.Habitats
{
public class Desert : Habitat, IDesertHabitat
  {
      public Desert (string name, double cageTemperature)
      {
          this.temperature = cageTemperature;
          this.publicname = name;
      }
  }
}