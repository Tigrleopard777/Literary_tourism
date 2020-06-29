/*
 * Routes class
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
    public class Routes
    {
        private int id_route;
        private string route_name;
        private int id_user;
        private int id_writer;
        private DateTime? date;
        private string route_description;
        private decimal route_rating;

        public int Id_route { get => id_route; set => id_route = value; }
        public string Route_name { get => route_name; set => route_name = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public int Id_writer { get => id_writer; set => id_writer = value; }
        public DateTime? Date { get => date; set => date = value; }
        public string Route_description { get => route_description; set => route_description = value; }
        public decimal Route_rating { get => route_rating; set => route_rating = value; }
    }
}
