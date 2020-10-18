/*
 * Mark of place class
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
    public class Mark_Of_Place : Marks
    {
        private int id_place;
        private decimal mark_of_place;

        public int Id_place { get => id_place; set => id_place = value; }
        public decimal Mark_of_place { get => mark_of_place; set => mark_of_place = value; }
    }
}
