using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader {
    public partial class Form2 : Form {
        public Form2(string links) {
            InitializeComponent();
            //wbBrowser.Url = new Uri(link);
            wbBrowser.Navigate(links);
        }

        public void Form2_Load(object sender, EventArgs e) {
            ;
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            //if (wbBrowser.CanGoBack) {
            //    btBack.Enabled = true;
            //} else {
            //    btBack.Enabled = false;
            //}

            //if (wbBrowser.CanGoForward) {
            //    btNext.Enabled = true;
            //} else {
            //    btNext.Enabled = false;
            //}
        }

        private void btBack_Click(object sender, EventArgs e) {
            if (wbBrowser.CanGoBack) {
                wbBrowser.GoBack();
            }
            
        }

        private void btNext_Click(object sender, EventArgs e) {
            if (wbBrowser.CanGoForward){
                wbBrowser.GoForward();

            }
            
        }
    }
}
