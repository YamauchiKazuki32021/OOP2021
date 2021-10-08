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
using System.Runtime.Serialization;


namespace SendMail {
    public partial class ConfigForm : Form {
        public ConfigForm() {
            InitializeComponent();
        }
        private Settings settings = Settings.getInstance();

        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            tbSender.Text = settings.sMailAddr();
            cbSsl.Checked = settings.bSsl();
        }

        private void btApply_Click(object sender, EventArgs e) {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
                            tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }


        private void btOk_Click(object sender, EventArgs e) {
            btApply_Click(sender, e);//適用ボタンの処理を呼び出し
            this.Close();

        }
        //送信データ登録
        //private void SettingRegist() {
        //s.Host = tbHost.Text;
        //s.MailAddr = tbUserName.Text;
        //s.Pass = tbPass.Text;
        //s.Port = int.Parse(tbPort.Text);
        //s.Sender = tbSender.Text;
        //s.Ssl = cbSsl.Checked;
        ////XMLファイルへ書き出し(シリアル化)
        //var xws = new XmlWriterSettings {
        //    Encoding = new System.Text.UTF8Encoding(false),
        //    Indent = true,
        //    IndentChars = "",
        //};
        //using (var writer = XmlWriter.Create("Settings.xml", xws)) {
        //    var serial = new DataContractSerializer(s.GetType());
        //    serial.WriteObject(writer, s);
        //}
        //}

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        //設定画面をロードすると一度だけ実行されるイベントハンドラー
        private void ConfigForm_Load(object sender, EventArgs e) {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.Pass;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.Sender;


        }
    }
}
