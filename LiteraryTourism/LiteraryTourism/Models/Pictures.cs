/*
 * Pictures class
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
    public class Pictures
    {
        private int id_picture;
        private string picture_name;
        private string picture_link;
        private string picture_type;

        public int Id_picture { get => id_picture; set => id_picture = value; }
        public string Picture_name { get => picture_name; set => picture_name = value; }
        public string Picture_link { get => picture_link; set => picture_link = value; }
        public string Picture_type { get => picture_type; set => picture_type = value; }
    }
}
