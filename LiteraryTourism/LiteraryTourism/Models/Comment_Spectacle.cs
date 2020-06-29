/*
 * Comment-spectacle class
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
    public class Comment_Spectacle : Comments
    {
        private int id_spectacle;

        public int Id_spectacle { get => id_spectacle; set => id_spectacle = value; }
    }
}
