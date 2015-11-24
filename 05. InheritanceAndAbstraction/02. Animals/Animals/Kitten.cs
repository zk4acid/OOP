using System;

namespace Animals
{
    class Kitten : Cat
    {
        private const string Gender = "female";

        public Kitten(string name, int age) : base(name, age, Gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am a Kitten: Kiayyyyy");
        }
    }
}
