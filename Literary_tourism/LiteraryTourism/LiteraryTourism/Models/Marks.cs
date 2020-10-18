/*
 * Marks class
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
   public class Marks
    {
        private int id_mark;
        private int id_user;
        private DateTime? date;
        private TimeSpan? time;
        private Boolean edit_flag;
        private string nick;

        public int Id_mark { get => id_mark; set => id_mark = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public DateTime? Date { get => date; set => date = value; }
        public TimeSpan? Time { get => time; set => time = value; }
        public bool Edit_flag { get => edit_flag; set => edit_flag = value; }
        public string Nick { get => nick; set => nick = value; }
    }
}
