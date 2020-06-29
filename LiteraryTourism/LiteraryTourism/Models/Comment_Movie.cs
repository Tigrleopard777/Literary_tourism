/*
 * Comment-movie class
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
    public class Comment_Movie:Comments
    {
        private int id_movie;

        public int Id_movie { get => id_movie; set => id_movie = value; }
    }
}
