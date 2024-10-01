using Tyuiu.KhrapovDY.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KhrapovDY.Sprint1.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (verst * 1066.8) / 1000                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double verst, x;
            Console.Write("Введите расстояние в верстах: ");
            verst = Convert.ToDouble(Console.ReadLine());

            x = ds.VerstsToKilometers(verst);

            Console.WriteLine($"{verst} верст равно примерно {x} км.");

            Console.ReadKey();

        }
                
    }
}