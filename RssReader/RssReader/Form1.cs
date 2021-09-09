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
                foreach (var node in nodes) {
 
                    lbTitles.Items.Add(node);
                    
                }
                foreach (var item in links) {
                    link.Add(item.Value);
                }
            }

        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            //var title = (XElement)lbTitles.SelectedItem;
            //var item = title.NextNode.ToString();
            //    var s = Regex.Replace(item, "<link>", "");
            //    wbBrowser.Navigate(s);
            wbBrowser.Navigate(link[lbTitles.SelectedIndex]);

            
        }
    }
}
