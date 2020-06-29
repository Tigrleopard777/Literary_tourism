/*
 * Movie-writer class
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
    public class MovieWriter:Movies
    {
        private int id_writer;
        private string full_name;
        private DateTime? date_of_birth;
        private DateTime? date_of_death;
        private string place_of_birth;
        private string place_of_death;
        private string biography;

        public int Id_writer { get => id_writer; set => id_writer = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public DateTime? Date_of_birth { get => date_of_birth; set => date_of_birth = value; }
        public DateTime? Date_of_death { get => date_of_death; set => date_of_death = value; }
        public string Place_of_birth { get => place_of_birth; set => place_of_birth = value; }
        public string Place_of_death { get => place_of_death; set => place_of_death = value; }
        public string Biography { get => biography; set => biography = value; }
    }
}
