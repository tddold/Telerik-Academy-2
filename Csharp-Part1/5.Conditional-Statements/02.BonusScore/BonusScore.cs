using System;
//Problem 2. Bonus Score
//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//        If the score is between 1 and 3, the program multiplies it by 10.
//        If the score is between 4 and 6, the program multiplies it by 100.
//        If the score is between 7 and 9, the program multiplies it by 1000.
//        If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:
//score 	result
//2 	20
class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enetr your score:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("The bonus score is:");
        if (a >= 1 && a <= 3)
        {
            a = a * 10;
            Console.WriteLine(a);
        }
        else if ((a >= 4 && a <= 6))
        {
            a = a * 100;
            Console.WriteLine(a);
        }
        else if ((a >= 7 && a <= 9))
        {
            a = a * 1000;
            Console.WriteLine(a);
        }
        else if ((a <= 0 || a > 9))
        {
            Console.WriteLine("Invalid score");
        }

    }
}
