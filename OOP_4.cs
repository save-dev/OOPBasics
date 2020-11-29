using System;
using System.Collections.Generic;

namespace COOP
{
    internal class Converter
    {
        private readonly double usd, eur, rub;

        // Possible misleading values' names: these are exchange rates
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void Convert(double qty, string from, string to)
        {
            Dictionary<string, double> conversionData = new Dictionary<string, double>()
            {
                {"usd uah", usd * qty},
                {"eur uah", eur * qty},
                {"rub uah", rub * qty},
                {"uah usd", qty / usd},
                {"uah eur", qty / eur},
                {"uah rub", qty / rub},
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
