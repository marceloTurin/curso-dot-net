using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioHerancaPolimorfismo.Entities {
    class UsedProduct : Product {
        public DateTime manafactureDate { get; set; }

        public UsedProduct() {

        }

        public UsedProduct(string name, double price , DateTime manafactureDate) : base(name,price) {
            this.manafactureDate = manafactureDate;
        }

        public override string priceTag() {
            return $" {Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manafacture date: {manafactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
