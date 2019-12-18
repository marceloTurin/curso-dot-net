using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Course.Entities.Enums;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Coletnaod informações do usuário
            Console.WriteLine("Enter department's name:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior,MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Instanciando a classe departamento
            Departament dept = new Departament(deptName);

            //Instanciando a classe trabalhador passando o objeto departamento como parametro
            Worker worker = new Worker(name, level, baseSalary, dept);

            //Perguntando a quantidade de contratos do trabalhador
            Console.Write("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Enter #{i} contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Criando um objeto do tipo hora de contrato e adicionado na lista do trabalhador
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

            }


            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            //Substring pegando o mes da posicao 0 ate o 2 e o ano da posicao 3 em diante 
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for "+ monthAndYear + ": " + worker.Income(year,month).ToString("F2"),CultureInfo.InvariantCulture);



        }



    }
}