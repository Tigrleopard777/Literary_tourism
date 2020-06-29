/*
 * Comment-museum class
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
    public class Comment_Museum:Comments
    {
        private int id_museum;

        public int Id_museum { get => id_museum; set => id_museum = value; }
    }
}
