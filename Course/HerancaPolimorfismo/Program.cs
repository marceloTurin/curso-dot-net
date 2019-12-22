using System;
using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo {
    class Program {
        static void Main(string[] args) {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0.0, 500.00);


            // UPCATING

            Account acc1 = bacc;
            Account acc2 = new BusinessAcount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            BusinessAcount acc4 = (BusinessAcount)acc2;
            acc4.Loan(100);


            //BusinessAcount acc5 = (BusinessAcount)acc3;

            if(acc3 is BusinessAcount) {
                // BusinessAcount acc5 = (BusinessAcount)acc3;
                BusinessAcount acc5 = acc3 as BusinessAcount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingAccount) {
                //SavingAccount acc5 = (SavingAccount)acc3;
                SavingAccount acc5 = acc3 as SavingAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
