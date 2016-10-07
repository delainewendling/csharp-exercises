

namespace Zoolandia.Animals
{
  public class Animal
  {
      public string name { get; set; }
      public string height { get; set; }
      public string weight { get; set; }
      public string color {get; set;}
      public bool isSleeping{get; set;}
      public string commonName {get; set;}
      public string speciesName{ get; set; }
      public double speed {get; set;}
      public string reasonForRunning {get; set;}
      public int hours {get; set;}
      public string sleepLocation {get; set;}
      public string weirdFact {get; set;}
      //static means that you cannot call the method on new instances
      public string sleep (bool sleeping)
      {
          return sleeping ? "is now sleeping" : "is awake right now";
      }
      //Overloaded methods
      public string run(double speed)
      {
        return $"{speed} mph";
      }
      public string run(double speed, string reasonForRunning)
      {
        return $"{speed} mph when {reasonForRunning}";
      }
      public virtual string avgSleep(int hours)
      {
        return $"{hours} hours per day";
      }
      public string avgSleep(int hours, string sleepLocation)
      {
        return $"{hours} hours and they sleep {sleepLocation}";
      }
      //Overwrite methods
      public virtual string animalMessage()
      {
        return $"You got a cute, cuddly, {this.color} {this.speciesName} ({this.commonName}) named {this.name} who is {this.height} tall, weighs {this.weight}, and {sleep(this.isSleeping)}.\n";
      }
  }
}