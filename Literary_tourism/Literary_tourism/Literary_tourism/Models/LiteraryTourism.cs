/*
 * LiteraryToutism class
 * Describes Entities
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Literary_tourism.Models
{
    public class Users
    {
        public int Id_user { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nick { get; set; }
        public string User_type { get; set; }
    }

    public class Writers
    {
        public int Id_writer { get; set; }
        public string Full_name { get; set; }
        public DateTime? Date_of_birth { get; set; }
        public DateTime? Date_of_death { get; set; }
        public string Place_of_birth { get; set; }
        public string Place_of_death { get; set; }
        public string Biography { get; set; }
    }

    public class Museums
    {
        public int Id_museum { get; set; }
        public string Museum_name { get; set; }
        public string Museum_site { get; set; }
        public string Museum_description { get; set; }
        public decimal Museum_rating { get; set; }
        public string Museum_address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class Museum_writer
    {
        public int Id_museum { get; set; }
        public int Id_writer { get; set; }
    }

    public class Movies
    {
        public int Id_movie { get; set; }
        public string Movie_title { get; set; }
        public string Movie_link { get; set; }
        public int Year_of_issue { get; set; }
        public string Movie_description { get; set; }
        public decimal Movie_rating { get; set; }
    }

    public class Movie_writer
    {
        public int Id_movie { get; set; }
        public int Id_writer { get; set; }
    }

    public class Works
    {
        public int Id_work { get; set; }
        public int Id_writer { get; set; }
        public int Id_genre { get; set; }
        public string Work_name { get; set; }
        public string Work_link { get; set; }
        public string Work_description { get; set; }
        public decimal Work_rating { get; set; }
    }

    public class Genres_of_literature
    {
        public int Id_genre { get; set; }
        public int Id_kind { get; set; }
        public string Genre_name { get; set; }
    }

    public class Spectacles
    {
        public int Id_spectacle { get; set; }
        public int Id_theater { get; set; }
        public string Spectacle_title { get; set; }
        public string Director { get; set; }
        public string Spectacle_type { get; set; }
        public string Spectacle_link { get; set; }
        public string Spectacle_description { get; set; }
        public decimal Spectacle_rating { get; set; }
    }

    public class Theaters
    {
        public int Id_theater { get; set; }
        public string Theater_name { get; set; }
        public string Theater_site { get; set; }
        public string Theater_description { get; set; }
        public string Theater_address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class Spectacle_writer
    {
        public int Id_spectacle { get; set; }
        public int Id_writer { get; set; }
        public int Id_work { get; set; }
    }

    public class Places
    {
        public int Id_place { get; set; }
        public string Place_name { get; set; }
        public string Place_description { get; set; }
        public decimal Place_rating { get; set; }
        public string Place_address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class Types_of_place_relations
    {
        public int Id_type_relation { get; set; }
        public string Type_relation { get; set; }
    }

    public class Place_writer
    {
        public int Id_place { get; set; }
        public int Id_writer { get; set; }
        public int Id_type_relation { get; set; }
        public string Relation_description { get; set; }
    }

    public class Place_work
    {
        public int Id_place { get; set; }
        public int Id_work { get; set; }
        public string Excerpt_text { get; set; }
    }

    public class Pictures
    {
        public int Id_picture { get; set; }
        public string Picture_name { get; set; }
        public string Picture_link { get; set; }
        public string Picture_type { get; set; }
    }

    public class Picture_museum
    {
        public int Id_picture { get; set; }
        public int Id_museum { get; set; }
    }

    public class Picture_place
    {
        public int Id_picture { get; set; }
        public int Id_place { get; set; }
    }
    public class Picture_spectacle
    {
        public int Id_picture { get; set; }
        public int Id_spectacle { get; set; }
    }
    public class Picture_theater
    {
        public int Id_picture { get; set; }
        public int Id_theater { get; set; }
    }
    public class Picture_writer
    {
        public int Id_picture { get; set; }
        public int Id_writer { get; set; }
    }
    public class Comment_movie
    {
        public int Id_comment { get; set; }
        public int Id_movie { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Comment { get; set; }
        public Boolean Edit_flag { get; set; }
    }
    public class Comment_museum
    {
        public int Id_comment { get; set; }
        public int Id_museum { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Comment { get; set; }
        public Boolean Edit_flag { get; set; }
    }
    public class Comment_place
    {
        public int Id_comment { get; set; }
        public int Id_place { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Comment { get; set; }
        public Boolean Edit_flag { get; set; }
    }
    public class Comment_route
    {
        public int Id_comment { get; set; }
        public int Id_route { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Comment { get; set; }
        public Boolean Edit_flag { get; set; }
    }
    public class Comment_spectacle
    {
        public int Id_comment { get; set; }
        public int Id_spectacle { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Comment { get; set; }
        public Boolean Edit_flag { get; set; }
    }
    public class Comment_work
    {
        public int Id_comment { get; set; }
        public int Id_work { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Comment { get; set; }
        public Boolean Edit_flag { get; set; }
    }
    public class Mark_of_movie
    {
        public int Id_mark { get; set; }
        public int Id_movie { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Mark_Of_movie { get; set; }
        public bool Edit_flag { get; set; }
    }
    public class Mark_of_museum
    {
        public int Id_mark { get; set; }
        public int Id_museum { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Mark_Of_museum { get; set; }
        public bool Edit_flag { get; set; }
    }
    public class Mark_of_place
    {
        public int Id_mark { get; set; }
        public int Id_place { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Mark_Of_place { get; set; }
        public bool Edit_flag { get; set; }
    }
    public class Mark_of_route
    {
        public int Id_mark { get; set; }
        public int Id_route { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Mark_Of_route { get; set; }
        public bool Edit_flag { get; set; }
    }
    public class Mark_of_spectacle
    {
        public int Id_mark { get; set; }
        public int Id_spectacle { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Mark_Of_spectacle { get; set; }
        public bool Edit_flag { get; set; }
    }
    public class Mark_of_work
    {
        public int Id_mark { get; set; }
        public int Id_work { get; set; }
        public int Id_user { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Mark_Of_work { get; set; }
        public bool Edit_flag { get; set; }
    }
    public class Routes
    {
        public int Id_route { get; set; }
        public string Route_name { get; set; }
        public int Id_user { get; set; }
        public int Id_writer { get; set; }
        public DateTime? Date { get; set; }
        public string Route_description { get; set; }
        public decimal Route_rating { get; set; }
    }
    public class Route_movie
    {
        public int Id_route { get; set; }
        public int Id_movie { get; set; }
    }
    public class Route_museum
    {
        public int Id_route { get; set; }
        public int Id_museum { get; set; }
        public int Number_in_order { get; set; }
    }
    public class Route_place
    {
        public int Id_route { get; set; }
        public int Id_place { get; set; }
        public int Number_in_order { get; set; }
    }
    public class Route_spectacle
    {
        public int Id_route { get; set; }
        public int Id_spectacle { get; set; }
        public int Number_in_order { get; set; }
    }

}
