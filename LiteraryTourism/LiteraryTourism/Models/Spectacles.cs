/*
 * Spectacles class
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
    public class Spectacles
    {
        private int id_spectacle;
        private int id_theater;
        private string spectacle_title;
        private string director;
        private string spectacle_type;
        private string spectacle_link;
        private string spectacle_description;
        private decimal spectacle_rating;

        public int Id_spectacle { get => id_spectacle; set => id_spectacle = value; }
        public int Id_theater { get => id_theater; set => id_theater = value; }
        public string Spectacle_title { get => spectacle_title; set => spectacle_title = value; }
        public string Director { get => director; set => director = value; }
        public string Spectacle_type { get => spectacle_type; set => spectacle_type = value; }
        public string Spectacle_link { get => spectacle_link; set => spectacle_link = value; }
        public string Spectacle_description { get => spectacle_description; set => spectacle_description = value; }
        public decimal Spectacle_rating { get => spectacle_rating; set => spectacle_rating = value; }
    }
}
