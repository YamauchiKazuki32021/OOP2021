using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);
            

        }
        List<String> link = new List<string>();
        List<String> descs = new List<string>();
        List<DateTime> dates = new List<DateTime>();
        /* https://news.yahoo.co.jp/rss/topics/domestic.xml */ //URLコピペ用

        //指定したURL先からXMLデータを取得し、Title要素を取得し、リストボックスへセットする
        private void setRssTitle(string uri) {
          var uriString = string.Format(tbUrl.Text);
           using (var wc = new WebClient()) {
              wc.Headers.Add("Content-type", "charset=UTF-8");
              var url = new Uri(uriString);
              var stream = wc.OpenRead(url);

              XDocument xdoc = XDocument.Load(stream);
              var nodes = xdoc.Root.Descendants("title");
              var links = xdoc.Root.Descendants("link");
              var desc = xdoc.Root.Descendants("description");
              var items = xdoc.Root.Descendants("item");
              var date = xdoc.Root.Descendants("pubDate");

                 foreach (var node in items) {
                     //lbTitles.Items.Add(node.Value);
                     lbTitles.Items.Add(node.Element("title").Value);
                 }
                 foreach (var item in links) {
                     link.Add(item.Value);
                 }
                 foreach (var item in desc) {
                     descs.Add((string)item);
                 }
                foreach (var item in date) {
                    dates.Add((DateTime)item);
                }
           }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            //var title = (XElement)lbTitles.SelectedItem;
            //var item = title.NextNode.ToString();
            //    var s = Regex.Replace(item, "<link>", "");
            //    wbBrowser.Navigate(s);
            //wbBrowser.Navigate(link[lbTitles.SelectedIndex]);

            lbDesc.Text = descs[lbTitles.SelectedIndex];
            lbDate.Text = dates[lbTitles.SelectedIndex].ToString();
                        



        }

        private void btDisp_Click(object sender, EventArgs e) {
            
            var links = link[lbTitles.SelectedIndex];
            //var url = new Uri(link);
            var form2 = new Form2(links);
            //Form2.wbBrowser.Url = new Uri([lbTitles.SelectedIndex]);
            form2.Show();
            
        }
    }
}
