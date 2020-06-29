/*
 * Movies class
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
    public class Movies
    {
        private int id_movie;
        private string movie_title;
        private string movie_link;
        private int year_of_issue;
        private string movie_description;
        private decimal movie_rating;

        public int Id_movie { get => id_movie; set => id_movie = value; }
        public string Movie_title { get => movie_title; set => movie_title = value; }
        public string Movie_link { get => movie_link; set => movie_link = value; }
        public int Year_of_issue { get => year_of_issue; set => year_of_issue = value; }
        public string Movie_description { get => movie_description; set => movie_description = value; }
        public decimal Movie_rating { get => movie_rating; set => movie_rating = value; }
    }
}
