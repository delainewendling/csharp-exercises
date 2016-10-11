using System.Collections.Generic;
using Zoolandia.Animals;
using Zoolandia.Employees;

namespace Zoolandia.Habitats
{
  public class Habitat 
  {
    public List<Animal> inhabitants = new List<Animal>();
    public List<Employee> employeeCrew = new List<Employee>();
    public string publicname { get; set; }
    public double temperature { get; set; }
  }
}