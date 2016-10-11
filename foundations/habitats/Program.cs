using System;
using Zoolandia.Habitats;
using Zoolandia.Animals;
using Zoolandia.Employees;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zootopia! We have many different habitats and animals in our zoo as well as dedicated staff who train and take care of our animals");
            Zoo Zootopia = new Zoo();
            Aquarium freshwaterHabitat = new Aquarium("Freshwater Aquarium", true, 45.6);
            freshwaterHabitat.inhabitants.Add(new Trout());
            freshwaterHabitat.inhabitants.Add(new Walleye());
            freshwaterHabitat.inhabitants.Add(new Otter());
            freshwaterHabitat.employeeCrew.Add(new Employee("Adam"));
            freshwaterHabitat.employeeCrew.Add(new Employee("Aimee"));
            
            Aquarium saltwaterHabitat = new Aquarium("Saltwater Aquarium", false, 52.3);
            saltwaterHabitat.inhabitants.Add(new Dolphin());
            saltwaterHabitat.inhabitants.Add(new JellyFish());
            saltwaterHabitat.inhabitants.Add(new Shark());
            saltwaterHabitat.inhabitants.Add(new StingRay());
            saltwaterHabitat.employeeCrew.Add(new Employee("Jennifer"));
            saltwaterHabitat.employeeCrew.Add(new Employee("Gary"));

            Arctic arcticHabitat = new Arctic("Arctic Exhibit", 31);
            arcticHabitat.inhabitants.Add(new Penguin());
            arcticHabitat.inhabitants.Add(new PolarBear());
            arcticHabitat.employeeCrew.Add(new Employee("Amanda"));
            arcticHabitat.employeeCrew.Add(new Employee("Annie"));

            Desert desertHabitat = new Desert("Desert Exhibit", 90);
            desertHabitat.inhabitants.Add(new RattleSnake());
            desertHabitat.inhabitants.Add(new Scorpion());
            desertHabitat.inhabitants.Add(new Iguana());
            desertHabitat.employeeCrew.Add(new Employee("Richie"));
            desertHabitat.employeeCrew.Add(new Employee("Caroline"));

            Forest forestHabitat = new Forest("Forest Exhibit", 65);
            forestHabitat.inhabitants.Add(new Deer());
            forestHabitat.inhabitants.Add(new BlackBear());
            forestHabitat.inhabitants.Add(new Squirrel());
            forestHabitat.employeeCrew.Add(new Employee("Brad"));
            forestHabitat.employeeCrew.Add(new Employee("Jamal"));

            Jungle jungleHabitat = new Jungle("Jungle Exhibit", 85.3);
            jungleHabitat.inhabitants.Add(new Tiger());
            jungleHabitat.inhabitants.Add(new Gorilla());
            jungleHabitat.inhabitants.Add(new Parrot());
            jungleHabitat.employeeCrew.Add(new Employee("Brandy"));
            jungleHabitat.employeeCrew.Add(new Employee("Karen"));

            Prairie prairieHabitat = new Prairie("Jungle Exhibit", 85.3);
            prairieHabitat.inhabitants.Add(new Antelope());
            prairieHabitat.inhabitants.Add(new PrairieDog());
            prairieHabitat.employeeCrew.Add(new Employee("Caitlin"));
            prairieHabitat.employeeCrew.Add(new Employee("Monica"));

            Zootopia.ZooHabitats.Add(freshwaterHabitat);
            Zootopia.ZooHabitats.Add(saltwaterHabitat);
            Zootopia.ZooHabitats.Add(arcticHabitat);
            Zootopia.ZooHabitats.Add(desertHabitat);
            Zootopia.ZooHabitats.Add(forestHabitat);
            Zootopia.ZooHabitats.Add(jungleHabitat);
            Zootopia.ZooHabitats.Add(prairieHabitat);

            foreach (var habitat in Zootopia.ZooHabitats)
            {
                foreach (var employee in habitat.employeeCrew)
                {
                    Console.WriteLine($"{employee.employeeName}, ");
                };
                Console.WriteLine($"take care of the {habitat.publicname}\n This habitat is kept at {habitat.temperature} degrees Fahrenheit and houses the following animals: ");
                foreach (var animal in habitat.inhabitants)
                {
                    Console.WriteLine($"{animal.name}\n");
                };
            };
        }
    }
}
