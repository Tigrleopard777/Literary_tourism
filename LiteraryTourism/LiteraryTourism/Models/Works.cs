/*
 * Works class
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
    public class Works
    {
        private int id_work;
        private int id_writer;
        private int id_genre;
        private string work_name;
        private string work_link;
        private string work_description;
        private decimal work_rating;
        private string genre_name;

        public int Id_work { get => id_work; set => id_work = value; }
        public int Id_writer { get => id_writer; set => id_writer = value; }
        public int Id_genre { get => id_genre; set => id_genre = value; }
        public string Work_name { get => work_name; set => work_name = value; }
        public string Work_link { get => work_link; set => work_link = value; }
        public string Work_description { get => work_description; set => work_description = value; }
        public decimal Work_rating { get => work_rating; set => work_rating = value; }
        public string Genre_name { get => genre_name; set => genre_name = value; }
    }
}
