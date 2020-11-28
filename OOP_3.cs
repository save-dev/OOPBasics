using System;

namespace COOP
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // Пример использования
            Point p1 = new Point(1, 2);
            Point p2 = new Point(6, -1);
            Point p3 = new Point(0, 33);
            new Figure(p1, p2, p3);
        }
    }

    // координата точки
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
    }

    // многоугольник
    class Figure
    {
        public Figure(Point p1, Point p2, Point p3)
        {
            Console.WriteLine("Данная фигура - треугольник");
            PerimeterCalculator(p1, p2, p3);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            Console.WriteLine("Данная фигура - четырехугольник");
            PerimeterCalculator(p1, p2, p3, p4);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            Console.WriteLine("Данная фигура - пятиугольник");
            PerimeterCalculator(p1, p2, p3, p4, p5);
        }

        private static double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        private static void PerimeterCalculator(params Point[] points)
        {
            double perimeter = 0;
            for (var i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            perimeter += LengthSide(points[points.Length - 1], points[0]);
            Console.WriteLine(perimeter);
        }
    }
}

/*
Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов.
Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника.
 */
