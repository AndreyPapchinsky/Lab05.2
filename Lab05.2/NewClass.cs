using System;

namespace Lab05._2
{
    class NewClass
    {
        public static int NewMethod(double a, double b, double c, ref double x1, ref double x2 )
        {
            var discriminant = b * b - 4 * a * c;

            if (discriminant < 0) // Квадратное уравнение не имеет корней.
            {
                x1 = x2 = 0;
                return -1;
            }
            else
            {
                if (discriminant == 0) // Оба корня совпадают.
                {
                    x1 = -b / (2 * a);
                    return 0;
                }
                else // Корни найдены.
                {
                    x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    return 1;
                }
            }
        }
    }
}
