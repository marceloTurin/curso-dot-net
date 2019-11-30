using System;
using System.Globalization;

namespace Course {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtores de classe usando sobrecarga
        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;

        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

        //Properties do get set 
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }


        //Métodos
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        //Sobreposição da classe Object
        public override string ToString() {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
