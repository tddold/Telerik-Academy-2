using System;
//Problem 17.* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).



class calculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter x and y:");
        Console.Write("x=");
        int initX = int.Parse(Console.ReadLine());
        Console.Write("y=");
        int initY = int.Parse(Console.ReadLine());
        int absX = initX > 0 ? initX : -initX;
        int absY = initY > 0 ? initY : -initY;
        int a = absX >= absY ? absX : absY;
        int b = absX < absY ? absX : absY;
        a = a >= 0 ? a : -a;
        b = b >= 0 ? b : -b;
        int z = 0;
        bool found=false;
        while (found == false)
        {
            z =a - b;
            while (z>b)
            {
                z = z - b;
            }
            if (b % z == 0)
            {
                found = true;
            }
            else
            {
                a = b;
                b = z;
            }
        }
        Console.WriteLine("The GCD of {0} and {1} is {2}",initX,initY,z);
    }
}


