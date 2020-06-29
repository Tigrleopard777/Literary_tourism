/*
 * Route-museum class
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
    public class Route_Museum
    {
        private int id_route;
        private int id_museum;
        private int number_in_order;

        public int Id_route { get => id_route; set => id_route = value; }
        public int Id_museum { get => id_museum; set => id_museum = value; }
        public int Number_in_order { get => number_in_order; set => number_in_order = value; }
    }
}
