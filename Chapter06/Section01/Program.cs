﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は、" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("ページ数の合計は、" + books.Sum(x => x.Pages) + "ページ");
            Console.WriteLine("最も価格の高い本は、" + books.Max(x => x.Price) + "円");
            Console.WriteLine("最も価格の安い本は、" + books.Min(x => x.Price) + "円");
            Console.WriteLine("500円以上の本は、" + books.Where(x => 500 <= x.Price).Count() + "冊");
            Console.WriteLine("「物語」が含まれている本は、" + books.Count(x=> x.Title.Contains("物語")) + "冊");
            var bookData = books.Where(x => x.Title.Contains("物語"));
            foreach(var book in bookData) {
                Console.WriteLine(book.Title);
                
            }
            Console.WriteLine();

            //高額書籍ベスト３
            var books1 = books.OrderByDescending(x => x.Price).Take(3);
            foreach(var item in books1) {
                Console.WriteLine(item.Title+("、") + item.Price+("円"));
            }
            Console.WriteLine();

            var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
