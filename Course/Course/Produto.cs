﻿using System;
using System.Globalization;

namespace Course {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Construtores de classe usando sobrecarga
        public Produto() {
            _quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;

        }
        public Produto(string nome,double preco, int quantidade) : this(nome,preco) {
            _quantidade = quantidade;
        }

        
        /********************************************/

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {

            if(nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public double GetQuantidade() {
            return _quantidade;
        }


        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        //Sobreposição da classe Object
        public override string ToString() {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
