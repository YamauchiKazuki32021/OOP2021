using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail {
    public class Settings {
        private static Settings instance = null;

        //送信データ設定済み
        public static bool Set { get; private set; } = true;

        public int Port { get; set; }           //ポート番号
        public string Host { get; set; }        //ホスト名
        public string MailAddr { get; set; }    //メールアドレス
        public string Pass { get; set; }        //パスワード
        public bool Ssl { get; set; }           //SSL
        public string Sender { get; set; }

        //コンストラクタ
        private Settings() {

        }


        //インスタンス
        public static Settings getInstance() {
            if (instance == null) {
                instance = new Settings();
                try {
                    using (var reader = XmlReader.Create("Settings.xml")) {
                        var serial = new DataContractSerializer(typeof(Settings));
                        var set = serial.ReadObject(reader) as Settings;
                        instance.Host = set.Host;
                        instance.Port = set.Port;
                        instance.Pass = set.Pass;
                        instance.Sender = set.Sender;
                        instance.MailAddr = set.MailAddr;
                        instance.Ssl = set.Ssl;


                    }
                    //ファイルがない場合(初回起動時)
                } catch (Exception ex) {
                    Set = false;//データ未設定
                    var diag = MessageBox.Show("設定データがありません。\r\n設定画面を起動します。", "情報未設定",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //セキュリティエラーが検出された場合
                //} catch (SecurityException ex) {

                }
            }
            return instance;
        }

        //送信データ登録
        public bool setSendConfig(string host, int port, string mailAddr, string pass, bool ssl) {
            Host = host;
            MailAddr = mailAddr;
            Pass = pass;
            Port = port;
            Ssl = ssl;
            //XMLファイルへ書き出し(シリアル化)
            var xws = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "",
            };
            using (var writer = XmlWriter.Create("Settings.xml", xws)) {
                var serial = new DataContractSerializer(this.GetType());
                serial.WriteObject(writer, this);
            }
            Set = true;
            return true;

        }

        //初期値
        public string sHost() {
            return "smtp.gmail.com";
        }

        public string sPort() {
            return 587.ToString();
        }

        public string sMailAddr() {
            return "ojsinfosys01@gmail.com";
        }

        public string sPass() {
            return "Infosys2021";
        }

        public bool bSsl() {
            return true;
        }


    }
}
