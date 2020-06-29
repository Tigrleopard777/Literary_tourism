/*
 * Comment-place class
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
    public class Comment_Place:Comments
    {
        private int id_place;

        public int Id_place { get => id_place; set => id_place = value; }
    }
}
