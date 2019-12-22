﻿using System;
using HerancaPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsorced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hours");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y') {
                    Console.WriteLine("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach(Employee emp in list) {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2",CultureInfo.InvariantCulture)}");
            }

        }
    }
}