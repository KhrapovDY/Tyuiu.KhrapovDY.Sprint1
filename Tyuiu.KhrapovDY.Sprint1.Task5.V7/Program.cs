﻿using Tyuiu.KhrapovDY.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            double f;
            f = double.Parse(Console.ReadLine());
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того*");
            Console.WriteLine("* момента (в первой половине дня), когда часовая стрелка повернулась      *");
            Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(f);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.AngleToHoursMinutes(f);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
