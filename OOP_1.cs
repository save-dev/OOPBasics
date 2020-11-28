﻿using System;

namespace COOP
{
    class Rectangle
    {
        // Поля класса
        private double _side1;
        private double _side2;

        // Конструктор
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        // Свойства: площадь и периметр, только get
        double Area
        {
            get { return AreaCalculator(_side1, _side2); }
        }

        double Perimeter
        {
            get { return PerimeterCalculator(_side1, _side2); }
        }

        // Приватные методы расчета площади и периметра
        private static double AreaCalculator(double a, double b)
        {
            return a * b;
        }

        private static double PerimeterCalculator(double a, double b)
        {
            return 2 * (a + b);
        }

        public void Show()
        {
            Console.WriteLine($"Площадь прямоугольника:  {Area}");
            Console.WriteLine($"Периметр прямоугольника: {Perimeter}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())).Show();
        }
    }
}

/*
    Требуется: Создать класс с именем Rectangle.
    В теле класса создать два поля, описывающие длины сторон double side1, side2.
    Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
    поля side1 и side2 инициализируются значениями аргументов.
    Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
    прямоугольника - double PerimeterCalculator().
    Создать два свойства double Area и double Perimeter с одним методом доступа get.
    Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
    на экран периметр и площадь.
*/
