//Problem 2. Students and workers
//Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace accounts
{
    using System;
    using System.Collections.Generic;
    class MainProgram
    {
        static void Main()
        {
            Deposit deposit1 = new Deposit("Az", 1200, 10, new Individual("Az"), new DateTime(2015, 1, 1));
            double depositIntAmount = deposit1.CalculateIntAmount();
            Loan loan1 = new Loan("Az", 2000, 10, new Company("Az"), new DateTime(2014, 10, 1));
            double loanIntAmount = loan1.CalculateIntAmount();
            Mortgage mortgage1 = new Mortgage("Az", 2000, 10, new Company("Az"), new DateTime(2014, 01, 1));
            double mortgageIntAmount = mortgage1.CalculateIntAmount();
            deposit1.DepositMoney(depositIntAmount);
            loan1.DepositMoney(loanIntAmount);
            mortgage1.DepositMoney(mortgageIntAmount);
            Console.WriteLine("The balance in the accounts after adding the interest:");
            IEnumerable<Account> collection = new List<Account> (){deposit1, loan1, mortgage1};
            foreach (var acc in collection)
            {
                Console.WriteLine(acc);
            }
          

        }
    }
}
