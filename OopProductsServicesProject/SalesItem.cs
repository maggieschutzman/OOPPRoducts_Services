using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProject {

    public class SalesItem {

        public int Id { get; set; }
        public string Name;

        public virtual decimal CalcSales() {
            return decimal.MinusOne;
        }

        public SalesItem(int Id, string Name) {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
