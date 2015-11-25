using System;
using System.Linq;

namespace Animals
{
    class MainProgram
    {
        static void Main()
        {
            Animal[] animals = new Animal[10]
            {   new Cat("Pesho", 2, "male"),
                new Kitten("Penka", 3),
                new Tomcat("Gosho", 1),
                new Frog("Mitko", 3, "male"),
                new Dog("Goran", 2, "male"),
                new Dog("Dimitrichka", 2, "female"),
                new Cat("Ani", 1, "female"),
                new Frog("Geri", 4, "female"),
                new Tomcat("Pesho", 5),
                new Kitten("Marta", 6) };

            animals.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderByDescending(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine($"{group.AnimalName}'s average age is: {group.AverageAge}"));
        }
    }
}
