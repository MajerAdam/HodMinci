using System;

namespace HodMinci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Random r = new Random();
            int coin;
            int count = 0;
            bool hit = false;
            double u = 0;
            double y = 10_000;
            for (int i = 0; i < y; i++)
            {
                for (int x = 0; x < 100; x++)
                {
                    coin = r.Next(0, 2);
                    if (coin == 0)
                    {
                        count += 1;
                    }
                    if (coin == 1)
                    {
                        count = 0;
                    }
                    if (count == 7)
                    {
                        hit = true;
                        x = 100;
                    }
                }
                if (hit)
                {
                    u++;        
                }
                count = 0;
                hit = false;
            }
            Console.WriteLine(u/y * 100);
        }
    }
}
