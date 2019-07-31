using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProject {

    public class Service : SalesItem {

        public int Rate { get; set; }
        public int Hours { get; set; }

        public override decimal CalcSales() {
            return Rate * Hours;
        }

        public Service (int Id, string Name, int Rate, int Hours)
            : base(Id, Name) {
            this.Rate = Rate;
            this.Hours = Hours;
        }
    }
}
