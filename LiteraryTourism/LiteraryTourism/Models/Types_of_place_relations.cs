/*
 * Types of place relations class
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteraryTourism.Models
{
    public class Types_of_place_relations
    {
        private int id_type_relation;
        private string type_relation;

        public int Id_type_relation { get => id_type_relation; set => id_type_relation = value; }
        public string Type_relation { get => type_relation; set => type_relation = value; }
    }
}
