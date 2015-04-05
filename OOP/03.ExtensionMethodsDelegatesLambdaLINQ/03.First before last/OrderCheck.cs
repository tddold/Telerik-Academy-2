//Problem 3. First before last
//Write a method that from a given array of students finds all students whose first name
//is before its last name alphabetically.
//Use LINQ query operators.

//Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//Problem 5. Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions 
//sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.


namespace task0304
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class OrderCheck
    {
        public static void Main()
        {
            var students=new student[]{
            new student("Pesho","Ivanov",22),
            new student("Atanas", "Georgiev",21),
            new student("Stefan", "Atanasov",25),
            new student("Anton", "Atanasov",18),
            new student("Anton", "Petrov",22),
            new student("Dimitar", "Penev",24)
            };
            //Problem 3
            //var namesFiltered = students.Where(st => st.FirstName.CompareTo(st.LastName)<=0).ToList();
            var namesFiltered = from st in students
                                where st.FirstName.CompareTo(st.LastName)<=0                               
                                select st;

            

            Console.WriteLine("All students whose first name is before its last name alphabetically:");
            Console.WriteLine(string.Join((", "),namesFiltered));
            Console.WriteLine();
            //Problem 4
            //var ageFiltered = students.Where(st => st.Age >= 18 && st.Age <= 24).ToList();
            var ageFiltered = from st in students
                                where st.Age >=18 &&st.Age<=24 
                                select st;
            
            Console.WriteLine("All students with age between 18 and 24.");
            Console.WriteLine(string.Join((", "), ageFiltered));
            Console.WriteLine();
            //problem 5
            var sortedByNameLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);            
            Console.WriteLine("Sort the students by first name and last name in descending order:");
            Console.WriteLine(string.Join((", "),sortedByNameLambda));
            Console.WriteLine();
            var sortedByNameLINQ = from st in students
                          orderby st.FirstName descending, st.LastName descending
                          select st;
            Console.WriteLine("Sort the students by first name and last name in descending order:");
            Console.WriteLine(string.Join((", "), sortedByNameLINQ));
            Console.WriteLine();

        }
    }
}
