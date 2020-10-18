/*
 * Place-work class
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
    public class PlaceWork : Places
    {
        private int id_writer;
        private string full_name;
        private DateTime? date_of_birth;
        private DateTime? date_of_death;
        private string place_of_birth;
        private string place_of_death;
        private string biography;
        private int id_work;
        private string excerpt_text;
        private int id_Writer;
        private int id_genre;
        private string work_name;
        private string work_link;
        private string work_description;
        private decimal work_rating;
        private string genre_name;

        public int Id_writer { get => id_writer; set => id_writer = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public DateTime? Date_of_birth { get => date_of_birth; set => date_of_birth = value; }
        public DateTime? Date_of_death { get => date_of_death; set => date_of_death = value; }
        public string Place_of_birth { get => place_of_birth; set => place_of_birth = value; }
        public string Place_of_death { get => place_of_death; set => place_of_death = value; }
        public string Biography { get => biography; set => biography = value; }
        public int Id_work { get => id_work; set => id_work = value; }
        public string Excerpt_text { get => excerpt_text; set => excerpt_text = value; }
        public int Id_Writer { get => id_Writer; set => id_Writer = value; }
        public int Id_genre { get => id_genre; set => id_genre = value; }
        public string Work_name { get => work_name; set => work_name = value; }
        public string Work_link { get => work_link; set => work_link = value; }
        public string Work_description { get => work_description; set => work_description = value; }
        public decimal Work_rating { get => work_rating; set => work_rating = value; }
        public string Genre_name { get => genre_name; set => genre_name = value; }
    }
}
