/*
 * Mark of work class
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
    public class Mark_Of_Work : Marks
    {
        private int id_work;
        private decimal mark_of_work;

        public int Id_work { get => id_work; set => id_work = value; }
        public decimal Mark_of_work { get => mark_of_work; set => mark_of_work = value; }
    }
}
