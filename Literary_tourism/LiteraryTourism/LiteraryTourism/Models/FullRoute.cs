/*
 * Full route class
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
    public class FullRoute
    {
        private int num;
        private string name;
        private string address;
        private decimal latitude;
        private decimal longitude;

        public int Num { get => num; set => num = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public decimal Latitude { get => latitude; set => latitude = value; }
        public decimal Longitude { get => longitude; set => longitude = value; }
    }
}
