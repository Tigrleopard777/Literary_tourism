/*
 * Museums class
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
    public class Museums
    {
        private int id_museum;
        private string museum_name;
        private string museum_site;
        private string museum_description;
        private decimal museum_rating;
        private string museum_address;
        private decimal latitude;
        private decimal longitude;

        public int Id_museum { get => id_museum; set => id_museum = value; }
        public string Museum_name { get => museum_name; set => museum_name = value; }
        public string Museum_site { get => museum_site; set => museum_site = value; }
        public string Museum_description { get => museum_description; set => museum_description = value; }
        public decimal Museum_rating { get => museum_rating; set => museum_rating = value; }
        public string Museum_address { get => museum_address; set => museum_address = value; }
        public decimal Latitude { get => latitude; set => latitude = value; }
        public decimal Longitude { get => longitude; set => longitude = value; }
    }
}
