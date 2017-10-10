using System;

namespace PreparationTest
{
    public class Excersice1
    {
        public static void printLetters(int n)
        {
            if (n < 1)
            {
                return;
            }
            Console.Write('A');
            printLetters(--n);
            Console.Write('Z');
        }
        
        public static void printLetters2(int p, int q)
        {
            if (p > 0 && q > 0)
            {
                Console.Write('A');
                Console.Write('Z');
                printLetters2(p-1, q-1);
                return;
            }
            if (p > 0)
            {
                printLetters2(p-1, 0);
                Console.Write('A');
            }   
            if (q > 0)
            {
                printLetters2(0, q-1);
                Console.Write('Z');
            }   
        }
    }
}