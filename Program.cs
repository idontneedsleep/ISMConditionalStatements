using System;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int t = 1;
            int s = 0;
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= k; i++)
                {
                    t = t * j;
                }
                s = s + t;
                t = 1;
            }
            Console.WriteLine(s);
        }
    }
}
