using System;

namespace Lab05._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = new();
            double x2 = new();

            Console.WriteLine("Вычисление корней квадратного уравнения");

            Console.WriteLine("Введите первый (старший) коэффициент a: ");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второй (средний) коэффициент b: ");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третий (свободный) коэффициент c: ");
            var c = double.Parse(Console.ReadLine());

            switch (NewClass.NewMethod(a, b, c, ref x1, ref x2))
            {
                case -1: // Квадратное уравнение не имеет корней.
                    {
                        Console.WriteLine($"Кореней уравнения с коэффициентами a={a}, b={b}, c={c} нет.");
                        break;
                    }
                case 0: // Оба корня совпадают.
                    {
                        Console.WriteLine($"Корень уравнения с коэффициентами a={a}, b={b}, c={c} один: x1=x2={x1}.");
                        break;
                    }
                case 1: // Корни найдены.
                    {
                        Console.WriteLine($"Корени уравнения с коэффициентами a={a}, b={b}, c={c} равны: x1={x1}, x2={x2}.");
                        break;
                    }

            }
        }


    }
}
