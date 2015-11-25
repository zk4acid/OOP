using System;
using System.Text;

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

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} Age: {1} - {2}", this.Name, this.Age, Gender);
            return print.ToString();
        }
    }
}
