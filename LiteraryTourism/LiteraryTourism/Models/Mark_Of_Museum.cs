/*
 * Mark of museum class
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
    public class Mark_Of_Museum : Marks
    {
        private int id_museum;
        private decimal mark_of_museum;

        public int Id_museum { get => id_museum; set => id_museum = value; }
        public decimal Mark_of_museum { get => mark_of_museum; set => mark_of_museum = value; }
    }
}
