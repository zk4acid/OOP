using System;

namespace Persons
{
    class MainProgram
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 22, "Pesh@abv.bg");
            Console.WriteLine(pesho.ToString());
        }
    }
}
