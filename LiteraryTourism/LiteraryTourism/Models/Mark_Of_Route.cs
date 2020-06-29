/*
 * Mark of route class
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
    public class Mark_Of_Route : Marks
    {
        private int id_route;
        private decimal mark_of_route;

        public int Id_route { get => id_route; set => id_route = value; }
        public decimal Mark_of_route { get => mark_of_route; set => mark_of_route = value; }
    }
}
