using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProject {
    class Membership : SalesItem {

        public int Fee { get; set; }
        public int Units { get; set; }


        public override decimal CalcSales() {
            return Fee * Units;

        }

        public Membership(int Id, string Name, int Fee, int Units)
            : base(Id, Name) {
            this.Fee = Fee;
            this.Units = Units;

        }

    }
}


