/*
 * Comment-work class
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
    public class Comment_Work : Comments
    {
        private int id_work;

        public int Id_work { get => id_work; set => id_work = value; }
    }
}
