﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで、１回だけ実行される。
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStrData.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(s => s.Equals(' '));
            TextBoxSpaceCount.Text = count.ToString();
           
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            var target = inputStrText.Text;
            var replaced = target.Replace("big","small");
            TextBoxWordChange.Text = replaced;
        }

        private void button5_3_3_Click(object sender, EventArgs e) {
            TextBoxWordCount.Text = inputStrText.Text.Split(' ').Length.ToString();        
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var vs = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            TextBoxLength.Text = string.Join(",",vs);
            
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            var sb = new StringBuilder(array[0]);
            foreach (var word in array.Skip(1)) {
                sb.Append(' ');
                sb.Append(word);

            }
            TextBox1.Text = sb.ToString();
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            foreach (var pair in inputStrData.Text.Split(';')) {
                var array = pair.Split('=');
                outputStrData.Text += ToJapanese(array[0]) + ":" + array[1] + "\r\n";
            }
        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家　 ";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません。");
        }
    }
}
