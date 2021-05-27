﻿using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {

        static void Main(string[] args) {
            //List<Sale> sales = ReadSales("Sales.csv");
        }
        //List 2-15
        //売上データを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filepath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filepath);
            foreach(string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
