using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioHerancaPolimorfismo.Entities {
    class ImportedProduct : Product {
        public double CustomsFee { get; set; }
        

        public ImportedProduct() {

        }

        public ImportedProduct(string name, double price , double customsFree) : base(name,price) {
            this.CustomsFee = customsFree;
        }

        public override string priceTag() {
            return $" {Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Customs free: $ {CustomsFee.ToString("F2",CultureInfo.InvariantCulture)})";
        }

        public double totalPrice() {
            return CustomsFee + Price;
        }
    }
}
