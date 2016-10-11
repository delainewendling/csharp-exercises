namespace Zoolandia.Habitats
{
public class Forest : Habitat, IForestHabitat
  {
      public Forest (string name, double cageTemperature)
      {
          this.temperature = cageTemperature;
          this.publicname = name;
      }
  }
}