using System;

namespace Animals
{
    class Tomcat : Cat
    {
        private const string Gender = "male";

        public Tomcat(string name, int age) : base(name, age, Gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am a Tomcat: Miayyyyyyyy");
        }
    }
}
