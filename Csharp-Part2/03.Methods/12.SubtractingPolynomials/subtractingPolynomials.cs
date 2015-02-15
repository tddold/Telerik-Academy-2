using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12. Subtracting polynomials
//Extend the previous program to support also subtraction and multiplication of polynomials.


class subtractingPolynomials
{
    static void Main()
    {
        double[] firstPolynom = enterPolynom();
        double[] secondPolynom = enterPolynom();
        double[] resultSub = substract(firstPolynom, secondPolynom);
        double[] resultMulti = substract(firstPolynom, secondPolynom);
        Console.WriteLine("The difference of the two polynom is with coeficients:");
        Array.Reverse(resultSub);
        Console.WriteLine("{0}", string.Join(", ", resultSub));
    }


    static double[] enterPolynom()
    {
        Console.Write("Enter max polynom power: ");
        int power = int.Parse(Console.ReadLine());
        double[] polynom = new double[power + 1];
        for (int i = power; i >= 0; i--)
        {

            Console.Write("{0}--->", new string('x', i));
            polynom[i] = double.Parse(Console.ReadLine());
            //Console.WriteLine();
        }
        return polynom;
    }
    static double[] substract(double[] first, double[] second)
    {

        int maxLength = first.Length > second.Length ? first.Length : second.Length;
        double[] result = new double[maxLength];
        for (int j = maxLength - 1; j >= 0; j--)
        {
            if (j + 1 > second.Length)
            {
                result[j] = first[j];
            }
            else if (j + 1 > first.Length)
            {
                result[j] = -second[j];
            }
            else
            {
                result[j] = first[j] - second[j];
            }
        }
        return result;
    }

    static double[] multi(double[] first, double[] second)
    {

        int maxLength = first.Length > second.Length ? first.Length : second.Length;
        double[] result = new double[maxLength];
        for (int j = maxLength - 1; j >= 0; j--)
        {
            if (j + 1 > second.Length)
            {
                result[j] = first[j];
            }
            else if (j + 1 > first.Length)
            {
                result[j] = -second[j];
            }
            else
            {
                result[j] = first[j] - second[j];
            }
        }
        return result;
    }
}

