using System.Collections.Generic;
using Course.Entities.Enums;

namespace Course.Entities {
    class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        public List<HourContract> Contrats { get; set; } = new List<HourContract>();


        public Worker() {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament ) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract) {
            Contrats.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contrats.Remove(contract);
        }

        public double Income(int year,int month) {

            double sum = BaseSalary; // Inicia com o salario base do funcionario

            //Percorre todos os contratos do funcionario
            foreach (HourContract contract in Contrats) {
                
                
                //Verifica o mes e o ano do contrato e soma o valor total a variavel
                if(contract.Date.Year == year && contract.Date.Month == month) {

                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
