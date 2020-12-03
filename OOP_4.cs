using System;
using System.Collections.Generic;

namespace COOP
{
    internal class Converter
    {
        private double Usd { get; }
        private double Eur { get; }
        private double Rub { get; }

        // Possible misleading values' names: these are exchange rates
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public void Convert(double qty, string from, string to)
        {
            Dictionary<string, double> conversionData = new Dictionary<string, double>()
            {
                {"usd uah", Usd * qty},
                {"eur uah", Eur * qty},
                {"rub uah", Rub * qty},
                {"uah usd", qty / Usd},
                {"uah eur", qty / Eur},
                {"uah rub", qty / Rub},
            };

            Console.Write($"Currency exchange from {from} to {to}: ");
            Console.WriteLine(conversionData[from + " " + to]);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // usage
            new Converter(28.5, 34.1, .37).Convert(100, "rub", "uah");
        }
    }
}

/*
Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну.
 */
