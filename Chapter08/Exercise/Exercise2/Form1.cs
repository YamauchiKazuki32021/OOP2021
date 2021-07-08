using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {


        Stopwatch sw = new Stopwatch();
        Timer timer = new Timer();

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            //lbTimerDisp.Text = "00:00:00.00";
        }

        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();
            timer1.Start();
            
        }

        private void Tm_Tick(object sender, EventArgs e) {
        }

        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
            timer1.Stop();
        }

        private void btReset_Click(object sender, EventArgs e) {
            sw.Reset();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            lbLapDisp.Items.Clear();
        }
        //画面更新用タイマーのタイムアウト
        private void timer1_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            timer1.Interval = 1;
            
        }

        private void btLap_Click(object sender, EventArgs e) {
            lbLapDisp.Items.Insert(0,sw.Elapsed.ToString(@"hh\:mm\:ss\.ff"));
        }
    }
}
