using System;
using System.Text;

namespace Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cvakkkk");
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} Age: {1} - {2}", this.Name, this.Age, this.Gender);
            return print.ToString();
        }
    }
}