using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [] numbers = new int[15] { 1, 3, 9, 5, 8, 7, 2, 11, 4, 19, 2, 13, 12, 17, 21 };
            int oddSum = 0;
            int i = 0;
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddSum = oddSum + numbers[i];
                    Console.WriteLine(oddSum);
                }
            }
        }
    }
}
