using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures.SpecialExcersices
{
    public class Recursion
    {
        // Much naive very wow
        public static double Pow(double x, uint y)
        {
            double res = x;
            for (int i = 0; i < y-1; i++)
            {
                 res *= x;
            }
            return res;
        }

        private static double[] dynamic; //store previously calculated values of smaller powers
        public static double DivnConPow(double x, uint y)
        {
            // even getal / 2
            // oneven getal = x + f(y - 1)
            // 
            
            
            dynamic = new double[y];
            uint biggestPowerOfTwo = 1;
            while (biggestPowerOfTwo < y)
            {
                biggestPowerOfTwo *= 2;
            }
            biggestPowerOfTwo /= 2;
            Console.WriteLine("biggest power of two: " + biggestPowerOfTwo);

            dynamic[1] = x;
            PowRec(x, 1, biggestPowerOfTwo);
            
            return -1;
        }

        private static void PowRec(double x, uint y, uint end)
        {
            y *= 2;
            if (y == end)
            {
                return;
            }
            
            dynamic.Add(y, );
            PowRec(x, y / 2, end);
        }
    }
}