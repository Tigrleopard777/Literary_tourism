/*
 * Users class
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace LiteraryTourism
{
    public class Users
    {
        private int id_user;
        private string login;
        private string password;
        private string nick;
        private string user_type;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Nick { get => nick; set => nick = value; }
        public string User_type { get => user_type; set => user_type = value; }
    }

   /* public override string ToString()
    {
        var details = string.Format("{0} {1} {2}"
            , Nick, Login, Password);
        return details;
    }*/

}
