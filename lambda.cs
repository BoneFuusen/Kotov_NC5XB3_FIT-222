using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static AMOGUS.Program;

namespace AMOGUS
{
    internal class Program
    {
        delegate void Delegate(double x, double y, double z);

        static void Main()
        {
            double x, y, z;
            Delegate sum = (double x, double y, double z) => Console.WriteLine(x + y + z);
            Delegate mult = (double x, double y, double z) => Console.WriteLine(x * y * z);
            Delegate max = (double x, double y, double z) => Console.WriteLine(Math.Max(Math.Max(x, y), z));
            Delegate min = (double x, double y, double z) => Console.WriteLine(Math.Min(Math.Min(x, y), z));
            Delegate mid = (double x, double y, double z) => Console.WriteLine((x + y + z) / 3);

            Console.WriteLine("Введите три числа через пробел:");
            string[] temp = Console.ReadLine().Split(' ');
            x = int.Parse(temp[0]); y = int.Parse(temp[1]); z = int.Parse(temp[2]);

            while (true)
            {

                Console.WriteLine(@"
Выбор действия:
1) Максимум
2) Минимум
3) Сумма
4) Произведение
5) Среднее арифметическое
6) Сменить числа
7) Выход
");
                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        max(x, y, z); break;
                    case "2":
                        min(x, y, z); break;
                    case "3":
                        sum(x, y, z); break;
                    case "4":
                        mult(x, y, z); break;
                    case "5":
                        mid(x, y, z); break;
                    case "6":
                        Console.WriteLine("Введите новые числа через пробел:");
                        string[] temp0 = Console.ReadLine().Split(' ');
                        x = int.Parse(temp0[0]); y = int.Parse(temp0[1]); z = int.Parse(temp0[2]);
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
