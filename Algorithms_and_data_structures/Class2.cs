using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    //Написать программу, вычисляющую число Фибоначчи для заданного значения
    //Рекурсивным способом. Предыдущее число + Предпредыдущее число = Текущее число.
    //Так же сделать через цикл.
    internal class Fibonachi
    {
        static public int Fibonacci(int i)
        {

            if (i == 0 || i == 1) return i;
            int x = Fibonacci(i - 1) + Fibonacci(i - 2);
            return x;

        }

        static public void Fibonaccirdy(string[] args)
        {

            Console.WriteLine("Используем алгоритм с рекурсией? Да/Нет");
            string choice = (Console.ReadLine());
            Console.WriteLine("До какого числа выводить значения Фибоначчи? ");
            int number = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case "Да":
                    {
                        if (number <= 15)
                        {
                            for (int i = 0; i < number; i++)
                                Console.WriteLine(Fibonacci(i));
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели слишком большое число,введите число поменьше. ");
                        }
                    }
                    break;


                case "Нет":
                    {
                        //Fn = Fn-1 + Fn-2      0, 1, 1, 2, 3, 5, 8, 13, 21, 34
                        int fib0 = 0;
                        int fib1 = 1;
                        int fib2;
                        Console.WriteLine(fib0);
                        Console.WriteLine(fib1);
                        for (int i = 3; i <= number; i++)
                        {
                            fib2 = fib0 + fib1;
                            Console.WriteLine(fib2);
                            fib0 = fib1;
                            fib1 = fib2;
                        }
                    }
                    break;

            }


        }


    }
}