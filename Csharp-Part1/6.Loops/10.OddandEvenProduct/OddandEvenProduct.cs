using System;
//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

class OddandEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers:");
        string numbers = Console.ReadLine();
        string[] words = numbers.Split(' ');
        int n = words.Length;
        int[] new_numbers = new int[n];
        int odd_product = 1;
        int even_product = 1;
        for (int a = 0; a < n; a++)
        {
            bool result = Int32.TryParse(words[a], out new_numbers[a]);
            if (result)
            {
                if ((a + 1) % 2 > 0)
                {
                    odd_product = odd_product * new_numbers[a];
                }
                else
                {
                    even_product = even_product * new_numbers[a];
                }
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                words[a] == null ? "<null>" : words[a]);
            }
        }
        if (odd_product - even_product == 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Porduct={0}", odd_product);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Odd product={0}", odd_product);
            Console.WriteLine("Even product={0}", even_product);
        }
    }
}
