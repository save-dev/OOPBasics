using System;
using System.Reflection;

namespace COOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vehicle boeing = new Plane(-11, 3, 3000000, 800, 1981, 12, 120);
            Vehicle mazda = new Car(5, 2, 18520, 90, 1995);
            Vehicle titanic = new Ship(5, 16, 1450000000, 75, 1895, 2000, "Odessa");
            boeing.Print();
        }
    }

    public static class Output
    {
        public static void Print(this Vehicle vehicle)
        {
            if (vehicle is Plane plane)
            {
                Console.WriteLine(plane.Height);
                Console.WriteLine(plane.PassengersQty);
                // and so on
            }
        }
    }

    public class Vehicle
    {
        public readonly double CoordX, CoordY;
        public readonly double Price, Speed;
        public int Year;

        protected Vehicle(double coordX, double coordY, double price, double speed, int year)
        {
            Speed = speed;
            Price = price;
            Year = year;
            CoordX = coordX;
            CoordY = coordY;
        }
    }

    internal class Plane : Vehicle
    {
        public readonly double Height;
        public readonly int PassengersQty;

        public Plane(double coordX,
            double coordY,
            double price,
            double speed,
            int year,
            double height,
            int passengersQty) :
            base(coordX, coordY, price, speed, year)
        {
            Height = height;
            PassengersQty = passengersQty;
        }
    }

    internal class Car : Vehicle
    {
        public Car(double coordX,
            double coordY,
            double price,
            double speed,
            int year) :
            base(coordX, coordY, price, speed, year)
        {
        }
    }

    internal class Ship : Vehicle
    {
        private readonly int PassengersQty;
        private readonly string Seaport;

        public Ship(double coordX,
            double coordY,
            double price,
            double speed,
            int year,
            int passengersQty,
            string seaport) :
            base(coordX, coordY, price, speed, year)
        {
            PassengersQty = passengersQty;
            Seaport = seaport;
        }
    }
}

/*
Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
выпуска).
Создайте 3 производных класса Plane, Саr и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
 */
