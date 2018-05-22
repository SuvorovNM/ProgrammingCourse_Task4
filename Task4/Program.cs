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
            double eps,summ=0;//eps - заданная точность, summ - итоговая сумма
            bool OK=true;//Проверка корректности ввода
            do
            {
                if (!OK) Console.WriteLine("Ошибка ввода!");
                Console.WriteLine("Введите точность для нахождения суммы (<0,1): ");
                OK = Double.TryParse(Console.ReadLine(), out eps);
            } while (!OK||eps>0.1||eps<=0);
            int i = 1;
            bool inf;
            do
            {
                summ += 1 / (double)(i * (i + 1));//Добавление элемента к сумме
                i++;
                inf = Double.IsInfinity(summ);//Проверка на то, стала ли сумма равна бесконечности
            } while (!inf&&(Math.Abs((1 / (double)(i * (i + 1)))) > eps));// Если сумма = бесконечности или следующий элемент < eps, то выход
            if (!inf)//Если сумма не бесконечность, то вывод результата
            {
                Console.WriteLine("Результат: " + summ);
            }
            //Иначе вывод сообщения об ошибке
            else Console.WriteLine("Невозможно вычислить результат!");
            Console.Read();
        }
    }
}
