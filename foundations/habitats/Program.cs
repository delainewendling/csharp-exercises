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
            Zootopia.ZooHabitats.Add(freshwaterHabitat);
            Zootopia.ZooHabitats.Add(saltwaterHabitat);
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
