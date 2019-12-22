﻿using System;
using HerancaPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo {
    class Program {
        static void Main(string[] args) {

            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001,"Alex",500.0,0.01));
            list.Add(new BusinessAcount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAcount(1004, "Anna", 500.0,500.00));

            double sum =  0.0;

            foreach(Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

            foreach(Account acc in list) {
                acc.Withdraw(10.0);
                Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
