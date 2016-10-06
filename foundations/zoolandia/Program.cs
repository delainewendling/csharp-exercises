using System;
using Zoolandia.Animals;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! We're making animals! Type 'giraffe', 'panda', or 'sloth' to see your animal buddy!");
            Animal animal = null;
            switch (Console.ReadLine())
            {
                case "giraffe": animal = new Giraffe()
                    {
                        name = "Randy",
                        animalName = "giraffe",
                        height = "14.5 ft",
                        weight = "1 ton",
                        color = "pink",
                        neckLength = "7.2 ft",
                        isSleeping = false
                    };
                    break;
                case "panda": animal = new Panda()
                    {
                        name = "Bao Bao",
                        animalName = "panda",
                        height = "2.7 ft",
                        weight = "320 lbs",
                        color = "white",
                        numberOfBambooStalks = 4,
                        isSleeping = true
                    };
                    break;
                case "sloth": animal = new Sloth()
                    {
                        name = "Larry",
                        animalName = "sloth",
                        height = "2 ft",
                        weight = "18 lbs",
                        color = "green",
                        toeNumber = 3,
                        isSleeping = true
                    };
                    break;
                default:
                    Console.WriteLine("Oops, that's not an animal");
                    break;
            }

            Console.WriteLine(animal.animalMessage());
            
        }

    }
}
