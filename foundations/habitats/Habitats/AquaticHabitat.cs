namespace Zoolandia.Habitats
{
public class Aquarium : Habitat, IAquaticHabitat
  {
      public bool freshwater { get; set; }
      public double volume { get; set; }
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
      }

      // `public_name`, and `saltwater` properties can only be set when habitat is created
      public Aquarium (string name, bool isFreshwater, double waterTemperature)
      {
          this.temperature = waterTemperature;
          freshwater = isFreshwater;
          this.publicname = name;
      }
  }
}