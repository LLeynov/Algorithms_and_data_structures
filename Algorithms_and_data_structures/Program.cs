using System;


namespace Algorithms_and_data_structures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Algorithms_and_data_structures";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Здравствуйте!\nПожалуйста,введите пункт и подпункт для выбора домашнего задания.\nДоступные для выбора пункты:\n1.1 - Напишите на C# функцию согласно блок-схеме.\n1.3 - Реализуйте функцию вычисления числа Фибоначчи.");
            string selectednumber = (Console.ReadLine());
            switch (selectednumber)
            {
                case "1.1":
                    {
                        Class1.NumberCheck();
                    }
                    break;


                case "1.3":
                    {
                        Fibonachi.Fibonaccirdy(args);
                    }
                    break;
            }
        }
    }

}
