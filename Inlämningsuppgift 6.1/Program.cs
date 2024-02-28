using System;

namespace uppgift_6._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addera(1, 2, 3));

        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            return summa;
        }
    }
}
