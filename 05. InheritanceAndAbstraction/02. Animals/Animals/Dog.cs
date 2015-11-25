﻿using System;
using System.Text;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark");
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} Age: {1} - {2}", this.Name, this.Age, this.Gender);
            return print.ToString();
        }
    }
}