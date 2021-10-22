using System;

namespace Computer_science_tasks_191021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 0;
            b = 1;
            c = 0;
            Console.WriteLine("{0} , {1}", a, b);
            while (a < 10000)
            {
                c = (a + b);
                d = (c + b);
                Console.WriteLine("{0} , {1}", c, d);
                a = c;
                b = d;
            }
            Console.WriteLine("Done");
            





        }
    }
}
