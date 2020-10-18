/*
 * Mark of spectacle class
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
    public class Mark_Of_Spectacle : Marks
    {
        private int id_spectacle;
        private decimal mark_of_spectacle;

        public int Id_spectacle { get => id_spectacle; set => id_spectacle = value; }
        public decimal Mark_of_spectacle { get => mark_of_spectacle; set => mark_of_spectacle = value; }
    }
}
