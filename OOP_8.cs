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
            foreach (var field in vehicle.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                Console.WriteLine(field.GetValue(vehicle));
            }
        }
    }

    public class Vehicle
    {
        private readonly double _coordX, _coordY;
        private readonly double _price, _speed;
        private int _year;

        protected Vehicle(double coordX, double coordY, double price, double speed, int year)
        {
            _speed = speed;
            _price = price;
            _year = year;
            _coordX = coordX;
            _coordY = coordY;
        }
    }

    internal class Plane : Vehicle
    {
        private readonly double _height;
        private readonly int _passengersQty;

        public Plane(double coordX,
            double coordY,
            double price,
            double speed,
            int year,
            double height,
            int passengersQty) :
            base(coordX, coordY, price, speed, year)
        {
            _height = height;
            _passengersQty = passengersQty;
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
        private readonly int _passengersQty;
        private readonly string _seaport;

        public Ship(double coordX,
            double coordY,
            double price,
            double speed,
            int year,
            int passengersQty,
            string seaport) :
            base(coordX, coordY, price, speed, year)
        {
            _passengersQty = passengersQty;
            _seaport = seaport;
        }
    }
}

// TODO: output name and full fields

/*
Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
выпуска).
Создайте 3 производных класса Plane, Саr и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
 */
