using System;
using System.Collections.Generic;

namespace COOP
{
    internal class Employee
    {
        private const double BaseRate = 2000, TaxRate = .2;
        public string Name { get; }
        public string Surname { get; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        private double Staffing(string position)
        {
            Dictionary<string, double> staffingRates = new Dictionary<string, double>()
            {
                {"Junior Manager", 1.0},
                {"Accountant", 1.1},
                {"Senior Manager", 1.4},
                {"Branch Manager", 1.65},
                {"Area Director", 1.82},
                {"Business Unit Director", 1.82},
                {"President", 3.1}
            };

            return staffingRates[position];
        }

        public (double, double, string) TaxSalary(string position, double seniority)
        {
            var salary = BaseRate * seniority * Staffing(position);
            var tax = salary * TaxRate;
            return (salary, tax, position);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee("Jane", "Doe");
            var (salary, tax, position) = employee.TaxSalary("Accountant", 14);

            Console.WriteLine($"Сотрудник:        {employee.Name} {employee.Surname}");
            Console.WriteLine($"Должность:        {position}");
            Console.WriteLine($"Оклад:            {salary}");
            Console.WriteLine($"Налоговый сбор:   {tax}");
        }
    }
}

/*
Создать класс Employee.
В теле класса создать пользовательский конструктор, который принимает два строковых аргумента,
и инициализирует поля, соответствующие фамилии и имени сотрудника.
Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
сбор.
Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
оклад и налоговый сбор.
 */
