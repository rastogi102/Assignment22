using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Source and Destination classes
            Source source = new Source
            {
                Id = 101,
                Name = "Tarun Sharma",
                Age = 30,
                Address = "Chandni Chowk",
                City="Delhi"
            };

            Destination destination = new Destination();

            // Map properties from the source to destination
            PropertyMapper.MapProperties(source, destination);

            // Display the values of properties in the Destination class to ensure the mapping was successful
            Console.WriteLine($"Destination Id: {destination.Id}");
            Console.WriteLine($"Destination Name: {destination.Name}");
            Console.WriteLine($"Destination Age: {destination.Age}");
            Console.WriteLine($"Destination City: {destination.City}"); // Additional property in Destination class
            Console.ReadKey();
        }
    }
    
}
