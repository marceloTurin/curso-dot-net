using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListaFuncionario {
    class Program {
        static void Main(string[] args) {
           

            Console.WriteLine("How many employees will be registred?");
            int numFunc = int.Parse(Console.ReadLine());

            //Cria lista do tipo funcionario
            List<Funcionario> list = new List<Funcionario>();


            for (int i = 1; i <= numFunc; i++) {
                Console.WriteLine("Enplyoee #"+i+":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Cria um funcionario colocando no final da lista
                list.Add(new Funcionario(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary incrase: ");
            int idEnviado = int.Parse(Console.ReadLine());

            //Procura o funcionario dentro da lista passando o id
            Funcionario func = list.Find(x => x.Id == idEnviado);


            //Verifica se existe o funcionario passado
            if(func != null) {
                //Acrescenta uma porcentagem no salario do funcionario
                Console.WriteLine("Enter the porcentage:");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                func.increaseSalary(percentage);

            } else {
                Console.WriteLine("This id does not exist");
            }

            //Mostra as informações do funcionario
            Console.WriteLine("Updated list of employees");
            foreach(Funcionario obj in list) {
                Console.WriteLine(obj);
            }


        }
    }
}
