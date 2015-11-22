﻿using System;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Invalid Name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Invalid Age");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null || value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Invalid Email");
                }
            }
        }

        public string ToString()
        {
            string informationAboutPerson = string.Format("{0} {1} {2}", this.Name, this.Age, this.Email);
            return informationAboutPerson;
        }
    }
}
