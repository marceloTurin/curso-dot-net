using System;
using System.Globalization;

namespace Course {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtores de classe usando sobrecarga
        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;

        }
        public Produto(string nome,double preco, int quantidade) : this(nome,preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        
        /********************************************/

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
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
