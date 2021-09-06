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
        //指定したURL先からXMLデータを取得し、Title要素を取得し、リストボックスへセットする
        private void setRssTitle(string uri) {
            var uriString = string.Format(tbUrl.Text);
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "", "");
                    lbTitles.Items.Add(s);
                }
            }

        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            //XDocument = XDocument.Load(string uri);
            //wbBrowser.Url(lbTitles.Items));
        }
    }
}
