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
        public interface IOp
        {
            abstract double Summ(double x, double y);
            abstract double Diff(double x, double y);
            abstract double Mult(double x, double y);
            abstract double Div(double x, double y);
        }

        public class Calculator : IOp
        {
            public delegate double Delegate(double x, double y);
            public Delegate Summer;
            public Delegate Differ;
            public Delegate Multer;
            public Delegate Diver;
            public Calculator()
            {
                Summer = Summ;
                Differ = Diff;
                Multer = Mult;
                Diver = Div;
            }
            public double Summ(double x, double y)
            {
                return x + y;
            }
            public double Diff(double x, double y)
            {
                return x - y;
            }
            public double Mult(double x, double y)
            {
                return x * y;
            }
            public double Div(double x, double y)
            {
                return x / y;
            }
        }

        static void Main()
        {
            double x, y;
            Calculator calc = new Calculator();
            while (true)
            {

                Console.WriteLine(@"
Выбор действия:
1) Сумма 
2) Разница
3) Умножеине
4) Деление
5) Выход
");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Summer(x, y));
                        Console.ReadKey();
                        break;
                    case "2":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Differ(x, y));
                        Console.ReadKey();
                        break;
                    case "3":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Multer(x, y));
                        Console.ReadKey();
                        break;
                    case "4":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        if (y != 0)
                        {
                            Console.WriteLine(calc.Diver(x, y));
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
