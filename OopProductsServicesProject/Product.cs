using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProject {

    public class Product : SalesItem {

        public decimal Price { get; set; }
        public int Units { get; set; }

        public override decimal CalcSales() {
            return Price * Units;
        }

        public Product(int Id, string Name, decimal Price, int Units)
            : base (Id, Name) {
            this.Price = Price;
            this.Units = Units;
        }
    }
}
