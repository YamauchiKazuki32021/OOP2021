using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                using (var reader = new StreamReader(ofdOpenFile.FileName,Encoding.GetEncoding("shift_jis"))) {
                    int i = 0;
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();   //1行読み込み
                        if (line.Contains(tbKeyWord.Text))
                            i++;
                    }
                    //tbOutput.Text += line + "\r\n";
                    //tbOutput.Text += i.ToString();
                    tbOutput.Text = "キーワード「" + tbKeyWord.Text + "」が含まれている行は、" + i.ToString() + "行です。";

                }
            }
        }

        private void btReadAllLines_Click(object sender, EventArgs e) {
            var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift-jis"));
            int i = 0;
            foreach (var item in lines) {
                if (item.Contains(tbKeyWord.Text)) {
                    i++;
                }
            }
            tbOutput.Text = "キーワード「" + tbKeyWord.Text + "」が含まれている行は、" + i.ToString() + "行です。";
        }

        private void btReadLines_Click(object sender, EventArgs e) {
            var count = File.ReadLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift-jis")).Count(s => s.Contains(tbKeyWord.Text));
            tbOutput.Text = "キーワード「" + tbKeyWord.Text + "」が含まれている行は、" + count.ToString() + "行です。";
        }
    }
}
