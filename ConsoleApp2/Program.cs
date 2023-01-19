using System;

namespace ConsoleApp2
{
    class Program
    {
        static double first;
        static double second;
        static double hypotenuse;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите катет a");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите катет b");
            second = Convert.ToInt32(Console.ReadLine());
            hypotenu();
            
        }

            public static void hypotenu()
            {
            hypotenuse =  Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2));
                Console.WriteLine($"Гипотенуза прямоугольного треугольника = {hypotenuse}");
            }
        }
    }

