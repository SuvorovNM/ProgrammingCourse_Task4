using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps,summ=0;
            bool OK;
            do
            {
                Console.WriteLine("Введите точность для нахождения суммы (<0,1): ");
                OK = Double.TryParse(Console.ReadLine(), out eps);
            } while (!OK||eps>0.1||eps<0);
            int i = 1;
            bool inf;
            do
            {
                summ += 1 / (double)(i * (i + 1));
                i++;
                inf = Double.IsInfinity(summ);
            } while (!inf&&(Math.Abs((1 / (double)(i * (i + 1)))) > eps));
            if (!inf)
            {
                Console.WriteLine("Результат: " + summ);
            }
            else Console.WriteLine("Невозможно вычислить результат!");
            Console.Read();
        }
    }
}
