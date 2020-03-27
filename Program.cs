using System;
using System.Globalization;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, coelho, rato, sapo, quantia;
            char tipo;
            double pcoelho, prato, psapo;

            coelho = 0; rato = 0; sapo = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                quantia = int.Parse(valores[0]);
                tipo = char.Parse(valores[1]);

                if (tipo == 'C')
                {
                    coelho = coelho + quantia;
                }
                else if (tipo == 'R')
                {
                    rato = rato + quantia;
                }
                else
                {
                    sapo = sapo + quantia;
                }
            }

            int total = coelho + rato + sapo;
            pcoelho = (double)coelho / total * 100.0;
            prato = (double)rato / total * 100.0;
            psapo = (double)sapo / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + pcoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + prato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + psapo.ToString("F2", CultureInfo.InvariantCulture) + " %");

                                  
        }

    }
}