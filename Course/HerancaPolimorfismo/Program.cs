using System;
using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo {
    class Program {
        static void Main(string[] args) {

            BusinessAcount account = new BusinessAcount(8010, "Bob brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            //account.Balance = 200;
        }
    }
}
