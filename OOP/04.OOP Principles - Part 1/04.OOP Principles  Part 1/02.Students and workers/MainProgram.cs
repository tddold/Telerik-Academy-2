﻿//Problem 2. Students and workers
//Define abstract class Human with first name and last name. 
//Define new class Student which is derived from Human and has new field – grade. 
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay
//and method MoneyPerHour() that returns money earned by hour by the worker. 
//Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() 
//extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.


namespace task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Aaa","Bbb",5),
                new Student("Ccc", "Ddd", 4),
                new Student("Eee", "Fff", 3),
                new Student("Ggg", "Hhh", 6),
                new Student("Iii", "Jjj", 4),
                new Student("Kkk", "Lll", 2),
                new Student("Mmm", "Nnn", 2),
                new Student("Ooo", "Ppp", 6),
                new Student("Qqq", "Rrr", 5),
                 new Student("Sss", "TTt", 4)
            };
            foreach (var st in listOfStudents)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            var sortedListOfStudents = listOfStudents.OrderBy(st => st.Grade).ToList();
            foreach (var st in sortedListOfStudents)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            List<Worker> listOfWorkers = new List<Worker>
            {
                new Worker("ZZZ","Bbb",12,6),
                new Worker("Lll", "Ooo",20, 8),
                new Worker("Jjj", "Eee",40, 7),
                new Worker("Ggg", "Www",45, 6),
                new Worker("Iii", "Jjj",12, 4),
                new Worker("Nnn", "Lll",20, 2),
                new Worker("Mmm", "Ppp",10, 9),
                new Worker("Iii", "Ppp",14, 6),
                new Worker("Rrr", "Rrr",22, 5),
                new Worker("Aaa", "Aaa",32, 8)
            };

            foreach (var st in listOfWorkers)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            var sortedListOfWorkers = listOfWorkers.OrderByDescending(wor => wor.MoneyPerHour()).ToList();
            foreach (var wor in sortedListOfWorkers)
            {
                Console.WriteLine(wor);
            }
            Console.WriteLine();

            List<Human> listOfHumans = new List<Human>();
            listOfHumans.AddRange(sortedListOfStudents);
            listOfHumans.AddRange(sortedListOfWorkers);

            var sortedList= listOfHumans.OrderBy(hum => hum.FirstName).ThenBy(hum=>hum.LastName).ToList();
            foreach (var wor in sortedList)
            {
                Console.WriteLine(wor);
            }


        }
    }
}
