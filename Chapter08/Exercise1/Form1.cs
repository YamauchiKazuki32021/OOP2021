using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = "";

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日"; 
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
            } 
            //tbOutput.Text =  dow + "です。";

            var dt1 = DateTime.Today;
            var dt2 = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            TimeSpan diff = dt1.Date - dt2.Date;
            tbOutput.Text = diff.Days.ToString();

            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です。";
            } else {
                tbLeapYear.Text = "閏年ではありません。";
            }
            var toDay = dTP.Value;
            var birthday = new DateTime(2001,10,10);
            //DateTime timeSpan = dt2.Year - birthday.Year;
            int age = toDay.Year - birthday.Year;
            if (birthday > toDay.AddYears(-age)) {
                age--;
            }
            
            tbAge.Text = age.ToString();

            
            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
        }
        public static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
