using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i < 10000; i++) {
                if (i % n == 2) {
                    Console.WriteLine(i);
                }
            }
            
                  
        }
    }
}
