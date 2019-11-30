using System;
using System.Globalization;

namespace ContaBancaria {
    class ContaBancaria {


        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }


        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;

        }
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(int deposito) {
            Saldo += deposito;
        }

        public void Saque(int saque) {
            Saldo -= saque;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular "
                + Titular
                + ", Saldo"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }



    }
}
