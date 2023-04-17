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
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AMOGUS
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(@" 
Меню: 

1.Array 
2.List 
3.Dictionary 
4.Queue 
5.Stack 
6.Sorted Set 
7.Sorted List 
8.Array List 
9.Hash Table 
");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: ArrayFuncs(); break;
                case 2: ListFuncs(); break;
                case 3: DictFuncs(); break;
                case 4: QueueFuncs(); break;
                case 5: StackFuncs(); break;
                case 6: SortSetFuncs(); break;
                case 7: SortListFuncs(); break;
                case 8: ArrayListFuncs(); break;
                case 9: HashTableFuncs(); break;
            }
        }

        static void ArrayFuncs()
        {
            Console.WriteLine("Укажите размерность массива:"); int n = int.Parse(Console.ReadLine());
            Array array = new Array[n];
            Console.WriteLine("Введите элементы массива через пробел:");

            array = Console.ReadLine().Split(' ');

            while (true)
            {
                int numer;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array);
                }
                Console.WriteLine(@" 
Возможные действия 

1) Общее число элементов 
2) Число измерений 
3) Бинарный поиск элемента 
4) Сортировка 
5) Возвращаем строку 
6) Значение по указанной позиции 
7) Поиск заданного объекта внутри всего одномерного массива 
8) Изменяем количество элементов в массиве до указанной величины 
9) Изменяем порядок элементов во всем одномерном массиве на обратный 
10)Очистка массива 
11)Выход 
");
                string num = Console.ReadLine();
                if (num == "1")
                {
                    Console.WriteLine(array.Length);
                    Console.ReadKey();
                }
                else if (num == "2")
                {
                    Console.WriteLine(array.Rank);
                    Console.ReadKey();
                }
                else if (num == "3")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Array.BinarySearch(array, numer));
                    Console.ReadKey();
                }
                else if (num == "4")
                {
                    Array.Sort(array);
                    Console.ReadKey();
                }
                else if (num == "5")
                {
                    Console.WriteLine(array.ToString());
                    Console.ReadKey();
                }
                else if (num == "6")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(array.GetValue(numer));
                    Console.ReadKey();
                }
                else if (num == "7")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Array.IndexOf(array, numer));
                    Console.ReadKey();
                }
                else if (num == "8")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Array.Resize<int>(ref array, numer);
                    Console.ReadKey();
                }
                else if (num == "9")
                {
                    Array.Reverse(array);
                    Console.ReadKey();
                }
                else if (num == "10")
                {
                    Array.Clear(array, 0, n - 1);
                }
                else if (num == "11")
                {
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }

        static void ListFuncs()
        {
            List<string> listik = new List<string>();
            Console.WriteLine("Введите базовые элементы списка через пробел");
            string[] temp1 = Console.ReadLine().Split(' ');
            while (true)
            {
                int numer, count;

                Console.WriteLine(listik);

                Console.WriteLine(@"
Возможные действия

1) Очистка
2) Входит ли значение в Лист 
3) Бинарный поиск
4) Устанавливаем ёмкость такой какой бы она была, если бы элементы уже были
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        listik.Clear();
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(listik.Contains(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        num = Console.ReadLine();
                        Console.WriteLine(listik.BinarySearch(num));
                        Console.ReadKey();
                        break;
                    case "4":
                        listik.TrimExcess();
                        Console.ReadKey();
                        break;
                    case "5":
                        num = Console.ReadLine();
                        listik.Add(num);
                        Console.ReadKey();
                        break;
                    case "6":
                        num = Console.ReadLine();
                        Console.WriteLine(listik.Equals(num));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine(listik.GetEnumerator());
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine(listik.GetHashCode());
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(listik.GetType());
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.WriteLine(listik.ToString());
                        Console.ReadKey();
                        break;

                    case "11":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }

        static void DictFuncs()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            while (true)
            {
                int numer, count;

                Console.WriteLine(dict);

                Console.WriteLine(@"
Возможные действия:

1) Очистка
2) Входит ли ключ в словарь 
3) Входит ли значение в словарь 
4) Устанавливаем ёмкость такой какой бы она была, если бы элементы уже были
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        dict.Clear();
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(dict.ContainsKey(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        num = Console.ReadLine();
                        Console.WriteLine(dict.ContainsValue(num));
                        Console.ReadKey();
                        break;
                    case "4":
                        dict.TrimExcess();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Введите ключ и значение через пробел");
                        string[] tempo = Console.ReadLine().Split(" ");
                        dict.Add(tempo[0], tempo[1]);
                        Console.ReadKey();
                        break;
                    case "6":
                        num = Console.ReadLine();
                        Console.WriteLine(dict.Equals(num));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine(dict.GetEnumerator());
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine(dict.GetHashCode());
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(dict.GetType());
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.WriteLine(dict.ToString());
                        Console.ReadKey();
                        break;

                    case "11":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }

        static void QueueFuncs()
        {
            Queue queue = new Queue();
            while (true)
            {
                int numer, count;

                Console.WriteLine(queue);

                Console.WriteLine(@"
Возможные действия:

1) Очистка
2) Входит ли элемент в очередь 
3) Возвращение объекта без его удаление
4) Возвращение и удаление объекта
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        queue.Clear();
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(queue.Contains(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine(queue.Peek());
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(queue.Dequeue());
                        Console.ReadKey();
                        break;
                    case "5":
                        num = Console.ReadLine();
                        queue.Enqueue(num);
                        Console.ReadKey();
                        break;
                    case "6":
                        num = Console.ReadLine();
                        Console.WriteLine(queue.Equals(num));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine(queue.GetEnumerator());
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine(queue.GetHashCode());
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(queue.GetType());
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.WriteLine(queue.ToString());
                        Console.ReadKey();
                        break;

                    case "11":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }

        static void StackFuncs()
        {
            Stack stack = new Stack();
            Stack stack1 = new Stack();
            while (true)
            {
                int numer, count;

                Console.WriteLine(stack);

                Console.WriteLine(@"
1) Очистка
2) Входит ли элемент в стэк
3) Возвращение объекта без его удаление
4) Возвращение и удаление объекта
5) Добавить элемент
6) Скобки
7) Выход
");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        stack.Clear();
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(stack.Contains(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine(stack.Peek());
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(stack.Pop());
                        Console.ReadKey();
                        break;
                    case "5":
                        num = Console.ReadLine();
                        stack.Push(num);
                        Console.ReadKey();
                        break;
                    case "6":
                        object b;
                        int value = 0;
                        num = Console.ReadLine();
                        foreach (var s in num)
                        {
                            if (s == '(' || s == '{' || s == '[')
                            {
                                stack1.Push(s);
                            }
                            else if (stack1.Count != 0)
                            {
                                b = stack1.Peek();
                                if (s == ')' && b is '(')
                                {
                                    stack1.Pop();
                                }
                                if (s == ']' && b is '[')
                                {
                                    stack1.Pop();
                                }
                                if (s == '}' && b is '{')
                                {
                                    stack1.Pop();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Нет");
                                Console.ReadKey();
                                value++;
                                break;
                            }
                        }
                        if (value == 0 && stack1.Count == 0)
                        {
                            Console.WriteLine("Да");
                            Console.ReadKey();
                        }
                        else if (value == 0 && stack1.Count != 0)
                        {
                            Console.WriteLine("Нет");
                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }

        static void SortSetFuncs()
        {
            SortedSet<string> sortset = new SortedSet<string>();
            while (true)
            {
                int numer, count;

                Console.WriteLine(sortset);

                Console.WriteLine(@"
Возможные действия:

1) Добавить элемент
2) Входит ли значение в Set
3) Удаление по значению
4) Получение Type
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        sortset.Clear();
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(sortset.Contains(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        num = Console.ReadLine();
                        sortset.Remove(num);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(sortset.GetType());
                        Console.ReadKey();
                        break;
                    case "5":
                        num = Console.ReadLine();
                        sortset.Add(num);
                        Console.ReadKey();
                        break;
                    case "6":
                        num = Console.ReadLine();
                        Console.WriteLine(sortset.Equals(num));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine(sortset.GetEnumerator());
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine(sortset.GetHashCode());
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(sortset.GetType());
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.WriteLine(sortset.ToString());
                        Console.ReadKey();
                        break;

                    case "11":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }

        static void SortListFuncs()
        {
            SortedList sortlist = new SortedList();
            while (true)
            {
                int numer, count;

                Console.WriteLine(sortlist);

                Console.WriteLine(@"
Возможные действия:

1) Очистка
2) Входит ли значение в Лист 
3) Удаление по значению
4) Получение Type
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        sortlist.Clear();
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(sortlist.Contains(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        num = Console.ReadLine();
                        sortlist.Remove(num);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(sortlist.GetType());
                        Console.ReadKey();
                        break;
                    case "5":
                        num = Console.ReadLine();
                        sortlist.Add(num, num);
                        Console.ReadKey();
                        break;
                    case "6":
                        num = Console.ReadLine();
                        Console.WriteLine(sortlist.Equals(num));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine(sortlist.GetEnumerator());
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine(sortlist.GetHashCode());
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(sortlist.GetType());
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.WriteLine(sortlist.ToString());
                        Console.ReadKey();
                        break;

                    case "11":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }

        static void ArrayListFuncs()
        {
            ArrayList arraylistik = new ArrayList();

            while (true)
            {
                Console.WriteLine(@"
1) Добавление элемента
2) Бинарный поиск
3) Часть Коллекции
4) Индекс первого вхождения элемента
5) Только для чтения 
6) Удаление части коллекции
7) Revers
8) Sort
9) Колличество элементов
10) Clear
");
                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        num = Console.ReadLine();
                        arraylistik.Add(num);
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(arraylistik.BinarySearch(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        int numer = Convert.ToInt32(Console.ReadLine());
                        int count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(arraylistik.GetRange(numer, count));
                        Console.ReadKey();
                        break;
                    case "4":
                        num = Console.ReadLine();
                        Console.WriteLine(arraylistik.IndexOf(num));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine(ArrayList.ReadOnly(arraylistik));
                        Console.ReadKey();
                        break;
                    case "6":
                        numer = Convert.ToInt32(Console.ReadLine());
                        count = Convert.ToInt32(Console.ReadLine());
                        arraylistik.RemoveRange(numer, count);
                        Console.ReadKey();
                        break;
                    case "7":
                        arraylistik.Reverse();
                        Console.ReadKey();
                        break;
                    case "8":
                        arraylistik.Sort();
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(arraylistik.Count);
                        Console.ReadKey();
                        break;
                    case "10":
                        arraylistik.Clear();
                        break;
                    default:
                        break;
                }
            }
        }

        static void HashTableFuncs()
        {
            int numer; int count;
            Hashtable hashtable = new Hashtable();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine(@"
1) Добавить key and value
2) Проверка, содержится ли ключ в hachtable
3) Проверка, содержится ли значение в hachtable
4) GetEnumerator
5) GetHash
6) GetType
7) Удаление элементов
8) Десериализация
9) Возвращение синхронизированной оболочки
10) Очистка
");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        numer = Convert.ToInt32(Console.ReadLine());
                        count = Convert.ToInt32(Console.ReadLine());
                        hashtable.Add(numer, count);
                        Console.ReadKey();
                        break;
                    case "2":
                        numer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(hashtable.Contains(numer));
                        Console.ReadKey();
                        break;
                    case "3":
                        count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(hashtable.ContainsValue(count));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(hashtable.GetEnumerator());
                        Console.ReadKey();
                        break;
                    case "5":
                        numer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(numer.GetHashCode());
                        Console.ReadKey();
                        break;
                    case "6":
                        numer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(hashtable.GetType);
                        Console.ReadKey();
                        break;
                    case "7":
                        numer = Convert.ToInt32(Console.ReadLine());
                        hashtable.Remove(numer);
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine(hashtable.OnDeserialization);
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(hashtable.IsSynchronized);
                        Console.ReadKey();
                        break;
                    case "10":
                        hashtable.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
