using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Choose option for calculation of the triangle surface:");
        bool isNot123 = true;
        int option = 0;
        while (isNot123)
        {
            Console.WriteLine("1---Side and an altitude to it");
            Console.WriteLine("2---Three sides");
            Console.WriteLine("3---Two sides and an angle between them");
            option = int.Parse(Console.ReadLine());
            if (option >= 1 && option <= 3)
            {
                isNot123 = false;
            }
            else
            {
                Console.WriteLine("Not number from 1 to 3. Please try again.");
            }
        }
        
        if (option == 1)
        {          
            double surface= surfaceAltitude();
            Console.WriteLine("THe surface of the triangle is {0:F2}",surface);
        }
        else if (option == 2)
        {
            
            double surface = surfaceThreeSides();
            Console.WriteLine("THe surface of the triangle is {0:F2}", surface);
        }
        else if (option == 3)
        {
            double surface = surfaceTwoSidesAngle();
            Console.WriteLine("THe surface of the triangle is {0:F2}", surface);
        }
    }

    public static double surfaceAltitude()
    {
         Console.WriteLine("Option 1 - enter side and altitude:");
         Console.Write("Side a:");
         double side = double.Parse(Console.ReadLine());
         Console.Write("Altitude:");
         double altitude = double.Parse(Console.ReadLine());
         double surfaceAltitude = ((double)side * altitude) / 2;
         return surfaceAltitude;
    }
    public static double surfaceThreeSides()
    {
        Console.WriteLine("Option 2 - enter three sides:");
        Console.Write("Side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Side c:");
        double sideC = double.Parse(Console.ReadLine());  
        double halfPer=(sideA+sideB+sideC)/(double)2;
        double surfaceThreeSides = Math.Sqrt(halfPer * (halfPer - sideA) * (halfPer - sideB) * (halfPer - sideC));
        return surfaceThreeSides;
    }
    public static double surfaceTwoSidesAngle()
    {
        Console.WriteLine("Option 3 - enter two side and an angle:");
        Console.Write("Side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Angle:");
        double angle = double.Parse(Console.ReadLine());        
        double surfaceTwoSidesAngle = (Math.Sin(angle)*sideA*sideB)/2;
        return surfaceTwoSidesAngle;
    }
}
