using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = today.ToString("ggyy",culture);
            var dayOfWeak = culture.DateTimeFormat.GetDayName(today.DayOfWeek);


            tbDateDisp.Text = string.Format("{0:yy/M/d HH:mm}", today) + "\r\n"; //M→月(Month)　mm→分(min)
            tbDateDisp.Text += string.Format("{0:yyyy年MM月dd日 HH時mm分ss秒}", today) + "\r\n";
            tbDateDisp.Text += string.Format("{0}年{1,2}月{2,2}日({3})", str,today.Month,today.Day,dayOfWeak);
            //tbDateDisp.Text = today.ToString("d");
        }

        private void Form1_Load(object sender, EventArgs e) {
            Timer tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Interval = 1000;
            tm.Start();

            tssTimeLabel.Text = DateTime.Now.ToString();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            tssTimeLabel.Text = DateTime.Now.ToString();
        }
    }
}
