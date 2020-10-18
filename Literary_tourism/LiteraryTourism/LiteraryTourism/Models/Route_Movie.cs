/*
 * Route-movie class
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
    public class Route_Movie
    {
        private int id_route;
        private int id_movie;

        public int Id_route { get => id_route; set => id_route = value; }
        public int Id_movie { get => id_movie; set => id_movie = value; }
    }
}
