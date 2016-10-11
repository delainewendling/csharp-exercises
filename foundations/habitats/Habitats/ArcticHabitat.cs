namespace Zoolandia.Habitats
{
public class Arctic : Habitat, IArcticHabitat
  {
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
      }

      // `public_name`, and `saltwater` properties can only be set when habitat is created
      public Arctic (string name, double cageTemperature)
      {
          this.temperature = cageTemperature;
          this.publicname = name;
      }
  }
}