using System;
using System.Text.RegularExpressions;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base (firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number shoud be in range [5 ... 10].");
                }
                if (IsInvalid(value))
                {
                    throw new ArithmeticException("Faculty number shoud exist only letters and digits.");
                }

                this.facultyNumber = value;
            }
        }

        private bool IsInvalid(string value)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            if (regex.IsMatch(value))
            {
                return true;
            }

            return false;
        }
    }
}
