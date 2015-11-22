using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            Computer veryExpensiveComputer = new Computer("Very Expensive Computer", new Component("Very Expensive Processor", 1500.00m), new Component(" Very Expensive Graphics Card", 1500.00m), new Component(" Very Expensive Motherboard", 1500.00m));
            Computer cheapComputer = new Computer("Cheap Computer", new Component("Cheap Processor", 20.00m), new Component("Cheap Graphics Card", 20.00m), new Component("Cheap Motherboard", 20.00m));
            Computer expensiveComputer = new Computer("Expensive Computer", new Component("Expensive Processor", 500.00m), new Component("Expensive Graphics Card", 500.00m), new Component("Expensive Motherboard", 500.00m));
            
            List<Computer> allComputers = new List<Computer>();
            allComputers.Add(cheapComputer);
            allComputers.Add(expensiveComputer);
            allComputers.Add(veryExpensiveComputer);
           
            foreach (Computer computer in allComputers.OrderBy(computer => computer.CalculateComputerPrice()))
            {
                computer.PrintComputerInformation();
                Console.WriteLine();
            }
        }
    }
}