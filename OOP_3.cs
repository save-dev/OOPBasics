using System;

namespace COOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Пример использования
            Point p1 = new Point(1, 2);
            Point p2 = new Point(6, -1);
            Point p3 = new Point(0, 33);
            Point p4 = new Point(0, 33);
            new Figure(p1, p2, p3, p4);
        }
    }

    // координата точки
    internal class Point
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
    internal class Figure
    {
        public Figure(params Point[] points)
        {
            switch (points.Length)
            {
                case 3:
                    Console.WriteLine("Данная фигура - треугольник");
                    PerimeterCalculator(points[0], points[1], points[2]);
                    break;
                case 4:
                    Console.WriteLine("Данная фигура - четырехугольник");
                    PerimeterCalculator(points[0], points[1], points[2], points[3]);
                    break;
                case 5:
                    Console.WriteLine("Данная фигура - пятиугольник");
                    PerimeterCalculator(points[0], points[1], points[2], points[3], points[4]);
                    break;
            }
        }

        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        private void PerimeterCalculator(params Point[] points)
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
