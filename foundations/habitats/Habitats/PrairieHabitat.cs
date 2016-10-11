namespace Zoolandia.Habitats
{
public class Prairie : Habitat, IPrairieHabitat
  {
      public Prairie (string name, double cageTemperature)
      {
          this.temperature = cageTemperature;
          this.publicname = name;
      }
  }
}