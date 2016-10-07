using System;

namespace Zoolandia.Animals
{
  public class Animal
  {
      public string name { get; set; }
      public string height { get; set; }
      public string weight { get; set; }
      public string color {get; set;}
      public bool isSleeping{get; set;}
      public string animalName {get; set;}
      public string speciesName{ get; set; }
      //static means that you cannot call the method on new instances
      public string sleep (bool sleeping)
      {
          return sleeping ? "is now sleeping" : "is awake right now";
      }

      public virtual string animalMessage()
      {
        return $"You got a cute, cuddly, {this.color} {this.speciesName} ({this.animalName}) named {this.name} who is {this.height} tall, weighs {this.weight}, and {sleep(this.isSleeping)}.\n";
      }
  }
}