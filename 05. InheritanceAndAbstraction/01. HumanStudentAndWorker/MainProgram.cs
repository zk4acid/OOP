using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentAndWorker
{
    class MainProgram
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Petar", "Petrov", "11119"));
            students.Add(new Student("Vasil", "Petrov", "11112"));
            students.Add(new Student("Petar", "Vasilev", "11117"));
            students.Add(new Student("Petar", "Yordanov", "11121"));
            students.Add(new Student("Yordan", "Petrov", "11115"));
            students.Add(new Student("Dimitar", "Petrov", "11116"));
            students.Add(new Student("Petar", "Dimitrov", "11113"));
            students.Add(new Student("Stamat", "Petrov", "11118"));
            students.Add(new Student("Georgi", "Dinev", "11111"));
            students.Add(new Student("Mancho", "Cvetkov", "11114"));

           
            foreach (var student in students.OrderBy(student => student.FacultyNumber))
            {
                Console.WriteLine("{0} {1} - Faculty number: {2}", student.FirstName, student.LastName, student.FacultyNumber);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Mincho", "Petkov", 500, 8));
            workers.Add(new Worker("Vasil", "Petkov", 200, 4));
            workers.Add(new Worker("Petko", "Vasilev", 500, 6));
            workers.Add(new Worker("Petko", "Yordanov", 550, 8));
            workers.Add(new Worker("Yordan", "Yordanov", 650, 7));
            workers.Add(new Worker("Dimitar", "Dimitrov", 250, 2));
            workers.Add(new Worker("Petar", "Stoyanov", 850, 8));
            workers.Add(new Worker("Stamat", "Stamatov", 1050, 10));
            workers.Add(new Worker("Anton", "Dinev", 1250, 16));
            workers.Add(new Worker("Mancho", "Peshov", 300, 8));


            foreach (var worker in workers.OrderByDescending(worker => worker.MoneyPerHour()))
            {
                Console.WriteLine("{0} {1} - Money per hour: {2:f2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine();

            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            foreach (var studentOrWorker in studentsAndWorkers.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
            {
                Console.WriteLine("{0} {1}", studentOrWorker.FirstName, studentOrWorker.LastName);
            }
        }
    }
}