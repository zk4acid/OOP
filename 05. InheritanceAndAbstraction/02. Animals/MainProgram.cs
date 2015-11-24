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

            Console.WriteLine("Cats: ");
            double averageAge = 0;
            int counter = 0;
            foreach (var animal in animals.Where(a => a.GetType().ToString() == "Animals.Cat"))
            {
                Console.WriteLine("{0} Age: {1} - {2}", animal.Name, animal.Age, animal.Gender);
                averageAge += animal.Age;
                counter++;
            }
            Console.WriteLine("Average age: {0}", averageAge / counter);
            Console.WriteLine();

            Console.WriteLine("Tomcats: ");
            averageAge = 0;
            counter = 0;
            foreach (var animal in animals.Where(a => a.GetType().ToString() == "Animals.Tomcat"))
            {
                Console.WriteLine("{0} Age: {1} - {2}", animal.Name, animal.Age, animal.Gender);
                averageAge += animal.Age;
                counter++;
            }
            Console.WriteLine("Average age: {0}", averageAge / counter);
            Console.WriteLine();

            Console.WriteLine("Kitten: ");
            averageAge = 0;
            counter = 0;
            foreach (var animal in animals.Where(a => a.GetType().ToString() == "Animals.Kitten"))
            {
                Console.WriteLine("{0} Age: {1} - {2}", animal.Name, animal.Age, animal.Gender);
                averageAge += animal.Age;
                counter++;
            }
            Console.WriteLine("Average age: {0}", averageAge / counter);
            Console.WriteLine();

            Console.WriteLine("Dogs: ");
            averageAge = 0;
            counter = 0;
            foreach (var animal in animals.Where(a => a.GetType().ToString() == "Animals.Dog"))
            {
                Console.WriteLine("{0} Age: {1} - {2}", animal.Name, animal.Age, animal.Gender);
                averageAge += animal.Age;
                counter++;
            }
            Console.WriteLine("Average age: {0}", averageAge / counter);
            Console.WriteLine();

            Console.WriteLine("Frogs: ");
            averageAge = 0;
            counter = 0;
            foreach (var animal in animals.Where(a => a.GetType().ToString() == "Animals.Frog"))
            {
                Console.WriteLine("{0} Age: {1} - {2}", animal.Name, animal.Age, animal.Gender);
                averageAge += animal.Age;
                counter++;
            }
            Console.WriteLine("Average age: {0}", averageAge / counter);
            Console.WriteLine();
        }
    }
}
