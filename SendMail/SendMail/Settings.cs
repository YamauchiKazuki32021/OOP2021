using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail
{
    public class Settings{
        public static int Port { get; set; }           //ポート番号
        public static string Host { get; set; }        //ホスト名
        public static string MailAddr { get; set; }    //メールアドレス
        public static string Pass { get; set; }        //パスワード
        public static bool Ssl { get; set; }           //SSL
        public static string Sender { get; set; }

        //初期値
        public static string sHost(){
            return "smtp.gmail.com";
        }

        public static string sPort() {
            return 587.ToString();
        }

        public static string sMailAddr() {
            return "ojsinfosys01@gmail.com";
        }

        public static string sPass() {
            return "OjsInfosys2021";
        }

    }
}
