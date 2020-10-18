/*
 * Places class
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
    public class Places
    {
        private int id_place;
        private string place_name;
        private string place_description;
        private decimal place_rating;
        private string place_address;
        private decimal latitude;
        private decimal longitude;

        public int Id_place { get => id_place; set => id_place = value; }
        public string Place_name { get => place_name; set => place_name = value; }
        public string Place_description { get => place_description; set => place_description = value; }
        public decimal Place_rating { get => place_rating; set => place_rating = value; }
        public string Place_address { get => place_address; set => place_address = value; }
        public decimal Latitude { get => latitude; set => latitude = value; }
        public decimal Longitude { get => longitude; set => longitude = value; }
    }
}
