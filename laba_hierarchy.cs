using System;
using System.Collections.Generic;
using System.Linq;

namespace AMOGUS
{
    class Student
    {
        public string fio;
        public string group;
        public string[] dis;
        public string[] grade;

        public Student(string fio, string group, string[] dis, string[] grade)
        {
            this.fio = fio;
            this.group = group;
            this.dis = dis;
            this.grade = grade;

        }
    }

    class Professor
    {
        public string fio;
        public string[] groups;
        public string[] subject;

        public Professor(string fio, string[] groups, string[] subject)
        {
            this.fio = fio;
            this.groups = groups;
            this.subject = subject;
        }
    }

    class Stuff
    {
        public string fio;
        public string debt;

        public Stuff(string fio, string debt)
        {
            this.fio = fio;
            this.debt = debt;
        }
    }

    class UPR
    {
        public string fio;
        public string debt;
        public string[] task;

        public UPR(string fio, string debt, string[] task)
        {
            this.fio = fio;
            this.debt = debt;
            this.task = task;
        }
    }
    public class Aboba
    {
        public static void Main()
        {
            List<Student> list = new List<Student>();
            List<Professor> proff = new List<Professor>();
            List<UPR> upr = new List<UPR>();
            List<Stuff> stuff = new List<Stuff>();
            string temp1;
            int temp0 = 0, temp = 0;
            while (true)
            {
                Console.WriteLine(@"
1. Добавить человека
2. Указы
3. Перечень преподавателей с должниками 
4. Вывод студента с его долгами
5. Выход");

                string num = Convert.ToString(Console.ReadLine());

                if (num == "1")
                {
                    Console.WriteLine(@"
1. Добавить студента
2. Добавить преподавателя
3. Добавить управляющего
4. Добавить рабочего");
                    num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите группа");
                        string group = Console.ReadLine();
                        Console.WriteLine("Кол-во прдметов");
                        temp = Convert.ToInt32(Console.ReadLine());
                        string[] dis = new string[temp];
                        string[] grade = new string[temp];
                        for (int i = 0; i < temp; i++)
                        {
                            Console.WriteLine("Введите предмет");
                            dis[i] = Console.ReadLine();
                            Console.WriteLine("Введите оценку");
                            grade[i] = Console.ReadLine();
                        }
                        list.Add(new Student(fio, group, dis, grade));
                    }
                    else if (num == "2")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Кол-во групп");
                        temp = Convert.ToInt32(Console.ReadLine());
                        string[] groups = new string[temp];
                        for (int i = 0; i < temp; i++)
                        {
                            Console.WriteLine("Введите группа");
                            groups[i] = Console.ReadLine();
                        }
                        Console.WriteLine("Кол-во предметов");
                        temp = Convert.ToInt32(Console.ReadLine());
                        string[] subject = new string[temp];
                        for (int i = 0; i < temp; i++)
                        {
                            Console.WriteLine("Введите предмет");
                            subject[i] = Console.ReadLine();
                        }
                        proff.Add(new Professor(fio, groups, subject));
                    }
                    else if (num == "3")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите должность");
                        string debt = Console.ReadLine();
                        Console.WriteLine("Кол-во указов");
                        temp = Convert.ToInt32(Console.ReadLine());
                        string[] task = new string[temp];
                        for (int i = 0; i < temp; i++)
                        {
                            Console.WriteLine("Введите указ");
                            task[i] = Console.ReadLine();
                        }
                        upr.Add(new UPR(fio, debt, task));
                    }
                    else if (num == "4")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите должность");
                        string debt = Console.ReadLine();
                        stuff.Add(new Stuff(fio, debt));
                    }

                }
                else if (num == "2")
                {
                    Console.WriteLine(@"
1. Указы студентам
2. Указы преподавателям
3. Указы вспомогательным
4. Указы общие");
                    temp1 = Console.ReadLine();
                    if (temp1 == "1")
                    {
                        for (int i = 0; i < upr.Count; i++)
                        {
                            for (int j = 0; j < upr[i].task.Length; j++)
                            {
                                if (upr[i].task[j].ToString().Substring(0, 2) == "ST" || upr[i].task[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].task[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (temp1 == "2")
                    {
                        for (int i = 0; i < upr.Count; i++)
                        {
                            for (int j = 0; j < upr[i].task.Length; j++)
                            {
                                if (upr[i].task[j].ToString().Substring(0, 2) == "PR" || upr[i].task[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].task[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (temp1 == "3")
                    {
                        for (int i = 0; i < upr.Count; i++)
                        {
                            for (int j = 0; j < upr[i].task.Length; j++)
                            {
                                if (upr[i].task[j].ToString().Substring(0, 2) == "VS" || upr[i].task[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].task[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (temp1 == "4")
                    {
                        for (int i = 0; i < upr.Count; i++)
                        {
                            for (int j = 0; j < upr[i].task.Length; j++)
                            {
                                if (upr[i].task[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].task[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                }
                else if (num == "3")
                {
                    temp1 = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list[i].grade.Length; j++)
                        {
                            if (list[i].grade[j] == "0")
                            {
                                temp0++;
                                for (int k = 0; k < proff.Count; k++)
                                {
                                    if (proff[k].subject.Contains(list[i].dis[j]) && proff[k].groups.Contains(list[i].group) && temp1 == proff[k].fio)
                                    {
                                        Console.WriteLine(list[i].dis[j] + " - " + list[k].group + " - " + list[i].fio);
                                        Console.ReadKey();
                                    }
                                }
                            }
                        }
                        if (temp0 == 0)
                        {
                            Console.WriteLine("Долгов нет");
                            Console.ReadKey();
                            temp0 = 0;
                        }
                    }
                    if (temp0 == 0)
                    {
                        Console.WriteLine("Данных не найдено");
                        Console.ReadKey();
                    }
                    else
                    {
                        temp0 = 0;
                    }
                }
                else if (num == "4")
                {
                    temp1 = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (temp1 == list[i].fio)
                        {
                            for (int j = 0; j < list[i].grade.Length; j++)
                            {
                                if (list[i].grade[j] == "0")
                                {
                                    temp0++;
                                    for (int k = 0; k < proff.Count; k++)
                                    {
                                        if (proff[k].subject.Contains(list[i].dis[j]) && proff[k].groups.Contains(list[i].group))
                                        {
                                            Console.WriteLine(list[i].dis[j] + " - " + proff[k].fio);
                                            Console.ReadKey();
                                        }
                                    }
                                }
                            }
                            if (temp0 == 0)
                            {
                                Console.WriteLine("Долгов нет");
                                Console.ReadKey();
                                temp0 = 0;
                            }
                        }

                    }
                    if (temp0 == 0)
                    {
                        Console.WriteLine("Данных не найдено");
                        Console.ReadKey();
                    }
                    else
                    {
                        temp0 = 0;
                    }
                }
                else if (num == "5")
                {
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}
