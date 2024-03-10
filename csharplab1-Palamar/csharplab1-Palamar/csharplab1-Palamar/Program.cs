#nullable enable
using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace webadd_Khoyskiy;

class Program
{
    static void task1()
    {
        Console.WriteLine("Task1 !");
        Console.Write("Введіть координати двох точок\n");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        //Point для введених координат
        Point point1 = new Point(a, b);
        Point point2 = new Point(c, d);
        Console.WriteLine(point1);
        Console.WriteLine(point2);

        //Обчислення відстані між точками
        double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        Console.WriteLine("Відстань між точками - " + distance);

    }
    static void task2()
    {
        Console.WriteLine("Task2 !");
        Console.Write("Введіть ціле число: ");

        int number = int.Parse(Console.ReadLine());

            // Перевірка, чи є число непарним
            if (number % 2 != 0)
            {
                Console.WriteLine($"{number} є непарним числом.");
            }
            else
            {
                Console.WriteLine($"{number} є парним числом.");
            }
    }
    static void task3()
    {
        Console.WriteLine("Task3 !");
        Console.Write("Введiть x та y:  ");
        string? strx = Console.ReadLine();

        float x = 0, y = 0;
        if (strx != null)
        {
            x = float.Parse(strx);
        }
        string? stry = Console.ReadLine();
        if (stry != null)
        {
            y = float.Parse(stry);
        }
        if (x * x + y * y < 25 || x * x + y * y > 100 || y < 0)
        {
            Console.WriteLine("Ні");
        }
        else
        {
            if ((x * x + y * y == 25 || x * x + y * y == 100) || (y==0 && (Math.Abs(x)<=10 && Math.Abs(x) >= 5)))
            {
                Console.WriteLine("На межі");
            }
            else { Console.WriteLine("Так"); }
        }
    }
    static void task4()
    {
        Console.Write("Номер масті = ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(y switch
        {
            1 => "Піки",
            2 => "трефи",
            3 => "бубни",
            4 => "черви",
            _ => "Помилка"
        });
    }
    static int Square(int a, int b)
    {
        return a * b;

    }
    static void task6()
    {
        Console.WriteLine("Введiть перше число:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введiть друге число:");
        int m = int.Parse(Console.ReadLine());
        double result = ((n + 1) / (Math.Pow(n,2) + Math.Pow(m, 2) + 1)) - (1.0 / ((m + 1) * (n + 1)));
        Console.WriteLine("Answer " + result.ToString($"F{3}"));
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Lab 1 !");
            Console.WriteLine("Введiть номер завдання:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    Console.WriteLine("Введiть перше число:");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введiть друге число:");
                    int num2 = int.Parse(Console.ReadLine());

                    int result = Square(num1, num2);

                    Console.WriteLine($"Добуток {num1} i {num2} дорiвнює {result}");
                    break;
                case 6:
                    task6();
                    break;
                default:
                    Console.WriteLine("Не вiрно");
                    break;
            }
        }
    }
}
