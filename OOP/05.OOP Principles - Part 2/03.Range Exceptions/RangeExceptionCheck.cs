//Problem 3. Range Exceptions
//Define a class InvalidRangeException<T> that holds information about an error condition
//related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and
//InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range 
//[1.1.1980 … 31.12.2013].



namespace InvalidRangeException
{
    using System;
    using System.Globalization;
    using System.Text;
    class TestEception
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int testNumber = int.Parse(Console.ReadLine());
            if (testNumber < 1 || testNumber > 100)
            {
                throw new InvalidRangeException<int>("Inavlid range [{0}...{1}]",1,100);
            }
            Console.WriteLine("Enter date:");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime start =new DateTime(1980,1,1) ;
            DateTime end =new DateTime(2013,12,31) ;            
            if (date<start||date>end)
            {
                throw new InvalidRangeException<DateTime>("Inavlid range [{0}...{1}]",new DateTime(1983,1,1),new DateTime(2013,31,12));
            }
        }
    }
}
