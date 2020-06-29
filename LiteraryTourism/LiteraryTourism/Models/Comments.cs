/*
 * Comments class
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteraryTourism
{
    public class Comments
    {
        private int id_comment;
        private int id_user;
        private DateTime? date;
        private TimeSpan? time;
        private string comment;
        private Boolean edit_flag;
        private string nick;

        public int Id_comment { get => id_comment; set => id_comment = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public DateTime? Date { get => date; set => date = value; }
        public TimeSpan? Time { get => time; set => time = value; }
        public string Comment { get => comment; set => comment = value; }
        public Boolean Edit_flag { get => edit_flag; set => edit_flag = value; }
        public string Nick { get => nick; set => nick = value; }
    }
}
