using System;

namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
