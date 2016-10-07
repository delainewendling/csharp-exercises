using System;
using Zoolandia.Animals;
using Zoolandia.Genuses;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! We're making animals! Type 'giraffe', 'giant panda', 'red panda', 'brown bear', polar bear' or 'sloth' to see your animal buddy!");
            Animal animal = null;
            switch (Console.ReadLine())
            {
                case "giraffe": animal = new Giraffe("Randy")
                    {
                        region = "West Africa",
                        height = "14.5 ft",
                        weight = "1 ton",
                        color = "pink",
                        neckLength = "7.2 ft",
                        isSleeping = false,
                        hours = 5,
                        speed = 37,
                        reasonForRunning = "when pursued by a predator",
                        weirdFact = "Baby Giraffes can stand within half an hour and after only 10 hours can actually run alongside their family."
                    };
                    break;
                case "giant panda": animal = new GiantPanda("Bao Bao")
                    {
                        height = "2.7 ft",
                        weight = "320 lbs",
                        color = "white",
                        numberOfBambooStalks = 4,
                        isSleeping = true,
                        speed = 20,
                        hours = 12,
                        weirdFact = "Giant Pandas spend about two-thirds of its day feeding and the remainder resting."
                    };
                    break;
                case "red panda": animal = new RedPanda("Basil")
                    {
                        height = "1 ft",
                        weight = "12 lbs",
                        color = "red",
                        numberOfBambooStalks = 1,
                        isSleeping = false,
                        weirdFact = "Red pandas use their ringed tails as wraparound blankets in the chilly Himalayan mountain heights.",
                        speed = 23,
                        hours = 11,
                        extinction = "Red pandas are endangered, victims of deforestation. Their natural space is shrinking as more and more forests are destroyed by logging and the spread of agriculture.",
                        sleepLocation = "high up in the trees"
                    };
                    break;
                case "brown bear": animal = new BrownBear("Kodiak")
                    {
                        height = "6 ft",
                        weight = "700 lbs",
                        color = "brown",
                        speed = 30,
                        hours = 4,
                        isSleeping = false,
                        hibernation = "Brown bears hibernate 152 - 213 days a year!",
                        weirdFact = "Even though brown bears are at the top of the food chain, Brown bears eat mostly grass, roots, and berries. Furthermore, brown bears need to eat about 84,000 calories each day to build up enough of a fat store to get them through the winter."
                    };
                    break;
                case "polar bear": animal = new PolarBear("Bao Bao")
                    {
                        height = "4.4 ft",
                        weight = "990 lbs",
                        color = "periwinkle",
                        isSleeping = false,
                        speed = 25,
                        hours = 15,
                        weirdFact = "Polar bears have black skin and although their fur appears white, it is actually transparent.",
                        attack = "Polar bears are very curious but they are also very risk adverse, so they wait until it’s quiet to let their curiosity take over. Therefore, night time is the most prominent time for attacks to happen. Make sure you are aware of your surroundings and prepared with bear spray when staying near polar bears"
                    };
                    break;
                case "sloth": animal = new Sloth("Larry")
                    {
                        height = "2 ft",
                        weight = "18 lbs",
                        color = "green",
                        toeNumber = 3,
                        isSleeping = true,
                        hours = 10,
                        sleepLocation = "hanging from a tree",
                        weirdFact = "A sloth only goes to the bathroom once a week!",
                        speed = 0.17
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
