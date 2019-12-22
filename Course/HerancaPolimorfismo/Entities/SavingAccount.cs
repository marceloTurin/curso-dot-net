﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities {
    class SavingAccount : Account {

        public double InteresRate { get; set; }

        public SavingAccount () {

        }

        public SavingAccount(int number, string holder, double balance,double interesRate) : base(number,holder,balance) {
            InteresRate = interesRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InteresRate;
        }

        public override void Withdraw(double amount) {
            base.Withdraw(amount); // Faz a operação da super classse
            Balance -=  2;
        }


    }
}
