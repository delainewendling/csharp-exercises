using System.Collections.Generic;
using Zoolandia.Employees;

namespace Zoolandia.Habitats
{
public class Arctic : Habitat
  {
      public double temperature = 0;
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
      }
      private List<Employee> arcticCrew = new List<Employee>();

      // `public_name`, and `saltwater` properties can only be set when habitat is created
      public Arctic (string name, double cageTemperature)
      {
          temperature = cageTemperature;
          this.publicname = name;
      }
  }
}