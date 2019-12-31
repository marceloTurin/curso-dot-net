using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressaoLambda.Entities {
    class ProductNew {

        public string Name { get; set; }
        public double Price { get; set; }

        public ProductNew(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}
