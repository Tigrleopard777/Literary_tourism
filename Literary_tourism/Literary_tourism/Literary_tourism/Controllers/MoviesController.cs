/*
 * Movies Controller
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Literary_tourism.Models;

namespace Literary_tourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public MoviesController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of movies with a search by title and name of the writer with whom the film is associated.
        /// </summary>
        /// <param name="movie_title">Movie title.</param>
        /// <param name="name">Full name of the writer.</param>
        /// <returns>List of movies.</returns>
        [HttpGet]
        public async Task<IActionResult> GetMovies(string movie_title = "", string name = "")
        {
            Movies _movies = new Movies();
            if (Request.Query.ContainsKey("movie_title"))
            {
                movie_title = (Request.Query.FirstOrDefault(p => p.Key == "movie_title").Value);
            }
            if (Request.Query.ContainsKey("name"))
            {
                name = (Request.Query.FirstOrDefault(p => p.Key == "name").Value);
            }
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var movies_ = (from movies in db.Set<Movies>()
                                join movie_writer in db.Set<Movie_writer>()
                                on movies.Id_movie equals movie_writer.Id_movie
                                join writers in db.Set<Writers>()
                                on movie_writer.Id_writer equals writers.Id_writer
                                where writers.Full_name.Contains(name) &&
                                movies.Movie_title.Contains(movie_title)
                                select new
                                {
                                    Id_movie = movies.Id_movie,
                                    Movie_title = movies.Movie_title,
                                    Movie_link = movies.Movie_link,
                                    Year_of_issue = movies.Year_of_issue,
                                    Movie_description = movies.Movie_description,
                                    Movie_rating = movies.Movie_rating,
                                    Id_writer = writers.Id_writer,
                                    Full_name = writers.Full_name,
                                    Date_of_birth = writers.Date_of_birth,
                                    Date_of_death = writers.Date_of_death,
                                    Place_of_birth = writers.Place_of_birth,
                                    Place_of_death = writers.Place_of_death,
                                    Biography = writers.Biography
                                }).ToList();

                if (movies_ == null)
                {
                    return NotFound();
                }

                return Ok(movies_);
           // }
        }
    }
}