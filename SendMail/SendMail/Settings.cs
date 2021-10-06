using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SendMail
{
    public class Settings{
        private static Settings instance = null;

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
            if(instance == null) {
                instance = new Settings();
                try {
                    XElement element = XElement.Load("Settings.xml");
                    using(var reader = XmlReader.Create("Setting.xml")) {
                        var serial = new DataContractSerializer(typeof(Settings));
                        var set = serial.ReadObject(reader) as Settings;
                        
                    }
                }
            }
            return instance;
        }

        //初期値
        public string sHost(){
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
