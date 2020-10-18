/*
 * Museum_writer class
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
    public class Museum_Writer
    {
        private int id_museum;
        private int id_writer;

        public int Id_museum { get => id_museum; set => id_museum = value; }
        public int Id_writer { get => id_writer; set => id_writer = value; }
    }
}
