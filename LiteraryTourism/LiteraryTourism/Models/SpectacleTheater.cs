/*
 * Spectacle-theater class
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
    public class SpectacleTheater:Spectacles
    {
   //     private int id_theater;
        private string theater_name;
        private string theater_site;
        private string theater_description;
        private string theater_address;
        private decimal latitude;
        private decimal longitude;

//        public int Id_theater { get => id_theater; set => id_theater = value; }
        public string Theater_name { get => theater_name; set => theater_name = value; }
        public string Theater_site { get => theater_site; set => theater_site = value; }
        public string Theater_description { get => theater_description; set => theater_description = value; }
        public string Theater_address { get => theater_address; set => theater_address = value; }
        public decimal Latitude { get => latitude; set => latitude = value; }
        public decimal Longitude { get => longitude; set => longitude = value; }
    }
}
