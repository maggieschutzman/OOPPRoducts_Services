using System;

namespace OopProductsServicesProject {
    class Program {
        static void Main(string[] args) {

            var pBW = new Product(1, "Basic Widget", 10, 2500);
            var pAW = new Product(2, "Advanced Widget", 25, 1500);
            var pSW = new Product(3, "Supreme Widget", 50, 1000);

            var sBS = new Service(11, "Basic Support", 25, 1000);
            var sPS = new Service(12, "Priority Support", 50, 550);
            var s247 = new Service(13, "24x7 Support", 100, 750);

            var sales = new SalesItem[] {
                pBW, pAW, pSW, sBS, sPS, s247
            };

            var total = 0M;

            foreach(var sale in sales) {
                total += sale.CalcSales();
            }

            Console.WriteLine($"Total sales is ${total}");

        }
    }
}
