using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Homework_7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] fibNum = new int[] {5,10,20};
            
            for (int i = 0; i < 3; i++)
            {
                //Метод 1
                stopwatch.Start();
                var rezalt =FiboCikl(fibNum[i]);
                stopwatch.Stop();
                Console.WriteLine("--FiboCikl--");
                Console.WriteLine("Число Фибоначчи " + fibNum[i] + " = " + rezalt);
                Console.WriteLine("Время работы - " + stopwatch.ElapsedTicks + " Ticks\n");
                stopwatch.Reset();

                //Метод 2
                stopwatch.Start();
                var rezalt2 = FiboRekurs(fibNum[i]);
                stopwatch.Stop();
                Console.WriteLine("--FiboRekurs--");
                Console.WriteLine("Число Фибоначчи " + fibNum[i] + " = " + rezalt);
                Console.WriteLine("Время работы - " + stopwatch.ElapsedTicks + " Ticks\n");
                stopwatch.Reset();
               
            }


            //Фибоначи цикл
            int FiboCikl(int n)
            {
                int el1 = 0;
                int el2 = 1;
                int rezalt = 0;

                for (int i = 2; i < n; i++)
                {
                    rezalt = el1 + el2;

                    el1 = el2;
                    el2 = rezalt;
                }
                return rezalt;
            }


            //Фибоначи рекурсия
            int FiboRekurs(int n)
            {
                if ((n == 0) || (n == 1))
                {
                    return n;
                }
                else
                {
                    return (FiboRekurs(n - 1) + FiboRekurs(n - 2));
                }
            }

            Console.ReadKey();
        }
    }
}