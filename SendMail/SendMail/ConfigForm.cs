using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }
        

        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = Settings.sHost();
            tbPort.Text = Settings.sPort();
            tbUserName.Text = Settings.sMailAddr();
            tbPass.Text = Settings.sPass();
            tbSender.Text = Settings.sMailAddr();
        }

        private void btApply_Click(object sender, EventArgs e) {
            Settings.Host = tbHost.Text;
            Settings.MailAddr = tbUserName.Text;
            Settings.Pass = tbPass.Text;
            Settings.Port = int.Parse(tbPort.Text);
            Settings.Sender = tbSender.Text;
        }

        private void btOk_Click(object sender, EventArgs e) {
            Settings.Host = tbHost.Text;
            Settings.MailAddr = tbUserName.Text;
            Settings.Pass = tbPass.Text;
            Settings.Port = int.Parse(tbPort.Text);
            Settings.Sender = tbSender.Text;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
