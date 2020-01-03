﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models {
    public class Departament {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament() {

        }

        public Departament(int id, string name) {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }

        //Calcula o total de vendas de cada vendedor do departamento
        public double TotalSales(DateTime initial, DateTime final) {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}