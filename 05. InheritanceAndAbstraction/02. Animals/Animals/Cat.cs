using System;
using System.Text;

namespace Animals
{
    class Cat : Animal
    {
        public Cat(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am cat: Miayyyyyyy");
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} Age: {1} - {2}", this.Name, this.Age, this.Gender);
            return print.ToString();
        }
    }
}
