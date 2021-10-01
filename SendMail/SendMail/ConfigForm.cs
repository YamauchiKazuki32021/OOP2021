using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace SendMail
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }
        private Settings s =  Settings.getInstance();

        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = s.sHost();
            tbPort.Text = s.sPort();
            tbUserName.Text = s.sMailAddr();
            tbPass.Text = s.sPass();
            tbSender.Text = s.sMailAddr();
            cbSsl.Checked = s.bSsl();
        }

        private void btApply_Click(object sender, EventArgs e) {
            SettingRegist();
        }


        private void btOk_Click(object sender, EventArgs e) {
            SettingRegist();//送信データ登録
            this.Close();
            var set = new Settings {

            }
              

        }
        //送信データ登録
        private void SettingRegist() {
            s.Host = tbHost.Text;
            s.MailAddr = tbUserName.Text;
            s.Pass = tbPass.Text;
            s.Port = int.Parse(tbPort.Text);
            s.Sender = tbSender.Text;
            s.Ssl = cbSsl.Checked;
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }


        
    }
}
