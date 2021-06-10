using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            //int count = 0;
            //Console.WriteLine($"後置:{count++}"); 前知式
            //Console.WriteLine($"前置:{++count}"); 後置式


            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if(product.Name =="") {
                //productが取得できなかった時の処理
                Console.WriteLine("productが取得できなかった。");
            } else {
                //productが取得できたときの処理
                Console.WriteLine("productが取得できた。");
            }       
                           

        }
        /**/
        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            sale = null;
            return sale?.Product;//null条件演算子
        }

    }

    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
