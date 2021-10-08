using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace SendMail {
    public partial class Form1 : Form {
        //設定画面
        private ConfigForm configForm = new ConfigForm();
        private Settings s = Settings.getInstance();
        public Form1() {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e) {
            if (!Settings.Set) {
                MessageBox.Show("送信情報を設定してください。", "情報未設定", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btSend.Enabled = false;
            try {
                if (tbTo.Text.Trim() == "" || tbMessage.Text.Trim() == "") {
                    MessageBox.Show("メールアドレスか、本文が入力されていません。",
                                    "情報未入力", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btSend.Enabled = true;
                } else if (tbTo.Text.Contains(null) || tbMessage.Text.Contains(null)){
                    MessageBox.Show("nullメールアドレスか、本文が入力されていません。",
                                    "情報未入力", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btSend.Enabled = true;
                } else { 


                
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(s.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                if (tbCc.Text != "") {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbBcc.Text != "") {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }


                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(s.MailAddr, s.Pass);
                smtpClient.Host = s.Host;
                smtpClient.Port = s.Port;
                smtpClient.EnableSsl = s.Ssl;
                 smtpClient.SendCompleted += SmtpClient_SendCompleted;
                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);
                 btSend.Enabled = true;
                }


            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                btSend.Enabled = true;
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
                btSend.Enabled = true;

            } else {
                MessageBox.Show("送信完了");
                Clear();
                btSend.Enabled = true; 
            }
        }

        private void btConfig_Click(object sender, EventArgs e) {
            new ConfigForm().ShowDialog();
        }
        //XMLファイルを読み込み(逆シリアル化)
        private void Form1_Load(object sender, EventArgs e) {
            //起動時に送信情報が未設定の場合設定画面を表示する
            if (!Settings.Set) {
                configForm.ShowDialog();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e) {
            Clear();
            
        }
        private void Clear() {
            tbTo.Text = "";
            tbTitle.Text = "";
            tbMessage.Text = "";
            tbCc.Text = "";
            tbBcc.Text = "";
        }
    }
}


//"ojsinfosys01@gmail.com", "Infosys2021"