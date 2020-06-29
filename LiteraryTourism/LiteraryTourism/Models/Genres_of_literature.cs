/*
 * Genres of literature class
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteraryTourism.Models
{
    public class Genres_of_literature
    {
        private int id_genre;
        private int id_kind;
        private string genre_name;

        public int Id_genre { get => id_genre; set => id_genre = value; }
        public int Id_kind { get => id_kind; set => id_kind = value; }
        public string Genre_name { get => genre_name; set => genre_name = value; }
    }
}
