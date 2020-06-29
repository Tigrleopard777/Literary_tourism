/*
 * Comment-route class
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
    public class Comment_Route : Comments
    {
        private int id_route;

        public int Id_route { get => id_route; set => id_route = value; }
    }
}
