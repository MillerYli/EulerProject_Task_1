using System;

namespace mynamespase
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sum = 0;
            for(int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Сумма кратных 3 и 5 равна: {0}", sum);
            Console.ReadKey();
        }
    }
}