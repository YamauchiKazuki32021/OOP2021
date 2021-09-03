using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            new Program();
        }
        
        //コンストラクタ
        public Program() {
            //DownloadString();
            //OpenReadSample();
            Console.WriteLine("Yahoo週間天気予報");
            Console.WriteLine("地域コードを入力");
            Console.WriteLine("1:前橋");//4210
            Console.WriteLine("2:みなかみ");//4220
            Console.WriteLine("3:宇都宮");//4110
            Console.WriteLine("4:水戸");//4010
            Console.WriteLine("9:その他(直接入力)");//任意のコード
            var i = int.Parse(Console.ReadLine());
            int code = 0;
            switch (i) {
                case 1:
                    code = 4210;
                    break;
                case 2:
                    code = 4220;
                    break;
                case 3:
                    code = 4110;
                    break;
                case 4:
                    code = 4010;
                    break;
                case 9:
                    Console.WriteLine("地域コードを入力");
                    code = int.Parse(Console.ReadLine());
                    break;

            }

            
           var results = GetWeatherReportFromYahoo(code);


            foreach (var s in results) {
                Console.WriteLine(s);
            }
            //Console.ReadLine();//入力待ち
        }
        //リスト14.15
        public void DownloadString() {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://www.yahoo.co.jp/");
            Console.WriteLine(html);
        }
        //リスト14.17（非同期処理）
        private void DownloadFileAsync() {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\kazuki\Desktop\a.txt");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();//アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e) {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e) {
            Console.WriteLine("ダウンロード完了");
        }

        //リスト14.18(ストリームとしてダウンロード)
        public void OpenReadSample() {
            var wc = new WebClient();
            using (var stream = wc.OpenRead(@"https://www.yahoo.co.jp/"))
            using (var sr = new StreamReader(stream, Encoding.UTF8)) {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);

            }

        }
        //リスト14.19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}
