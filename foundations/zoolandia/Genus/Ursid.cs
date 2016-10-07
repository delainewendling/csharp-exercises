using Zoolandia.Animals;

namespace Zoolandia.Genuses
{
  public class Ursid: Animal 
  {

    public override string animalMessage()
    {
      //The reason you don't need to write base for the methods on Animal is because they aren't being overridden by this class. You need to write base when you're using a method that is overriding a method from the base class.
      return $"{base.animalMessage()}";
    }
  }
}