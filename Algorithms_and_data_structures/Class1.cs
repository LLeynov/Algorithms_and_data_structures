using System;

namespace Algorithms_and_data_structures
{
    //Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм
    //проверки, простое число или нет.
    //1. Написать консольное приложение.
    //2. Алгоритм реализовать отдельно в классе согласно блок-схеме.
    //3. Написать проверочный код в main функции.
    //4. Код выложить на GitHub.
    internal class Class1
    {
        public static void NumberCheck()
        {
            Console.WriteLine("Введите желаемое для проверки число");
            int number = int.Parse(Console.ReadLine());
            while (number < 1)
            {
                Console.WriteLine("Вы ввели число меньше одного,пожалуйста,повторите попытку.");
                number = int.Parse(Console.ReadLine());
            }

            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++; i++;
                }
                else
                    i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Ваше число простое.");
            }
            else
            {
                Console.WriteLine("Ваше число составное.");
            }


        }
    }
}