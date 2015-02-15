using System;
//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:
//program 	user
//Please choose a type: 	
//1 --> int 	
//2 --> double 	3
//3 --> string 	
//Please enter a string: 	hello
//hello*
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int type = int.Parse(Console.ReadLine());
        switch (type)
        {
            case 1: Console.WriteLine("Please enter an integer:"); int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + 1);
                break;
            case 2: Console.WriteLine("Please enter a double:"); double doub = double.Parse(Console.ReadLine());
                Console.WriteLine(doub + 1);
                break;
            case 3: Console.WriteLine("Please enter a string"); string txt = Console.ReadLine();
                Console.WriteLine("{0}*", txt);
                break;
            default: Console.WriteLine("Not 1, 2 or 3"); break;
        }
    }
}