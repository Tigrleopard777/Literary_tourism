/*
 * Mark of movie class
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
    public class Mark_Of_Movie:Marks
    {
        private int id_movie;
        private decimal mark_of_movie;

        public int Id_movie { get => id_movie; set => id_movie = value; }
        public decimal Mark_of_movie { get => mark_of_movie; set => mark_of_movie = value; }
    }
}
