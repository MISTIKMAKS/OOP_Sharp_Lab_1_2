using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0; // вхідний аргумент
            double a = 0; // вхідний параметр
            double b = 0; // вхідний параметр
            double c = 0; // вхідний параметр
            double F = 0; // результат обчислення виразу
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            // спосіб 1: розгалуження в скороченій формі
            if (x < 0.6 && b + c != 0) {
                F = a * x * x + b * b + c;
            }
            if (x > 0.6 && b + c == 0) {
                F = (x - a) / (x - c);
            }
            if (!(x < 0.6 && b + c != 0) && !(x > 0.6 && b + c == 0)) {
                F = x / c + x / a;
            }
            Console.WriteLine("");
            Console.WriteLine($"1) F = {Math.Round(F, 2)}");
            // спосіб 2: розгалуження в повній формі
            if (x < 0.6 && b + c != 0)
            {
                F = a * x * x + b * b + c;
            }
            else
            {
                if (x > 0.6 && b + c == 0)
                {
                    F = (x - a) / (x - c);
                }
                else
                {
                    F = x / c + x / a;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"2) F = {Math.Round(F, 2)}");
            Console.ReadKey();
        }
    }
}
