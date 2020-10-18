/*
 * RouteMovie Controller
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
    public class RouteMovieController : ControllerBase
    {
        private readonly LiteraryTourismContext _context;

        public RouteMovieController(LiteraryTourismContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get list of movies associated with a route by id of the route.
        /// </summary>
        /// <param name="id">The unique route id.</param>
        /// <returns>List of movies associated with a route.</returns>
        [HttpGet]
        public async Task<IActionResult> GetRouteMovie(int id)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (Request.Query.ContainsKey("id"))
                {
                    id = Convert.ToInt32((Request.Query.FirstOrDefault(p => p.Key == "id").Value));
                }


                var movies_ = (from movies in db.Set<Movies>()
                                 join route_movie in db.Set<Route_movie>()
                                 on movies.Id_movie equals route_movie.Id_movie
                                 where route_movie.Id_route.Equals(id)
                                 select new
                                 {
                                     Id_movie = movies.Id_movie,
                                     Movie_title = movies.Movie_title,
                                     Movie_link = movies.Movie_link,
                                     Year_of_issue = movies.Year_of_issue,
                                     Movie_description = movies.Movie_description,
                                     Movie_rating = movies.Movie_rating
                                 }).ToList();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (movies_ == null)
                {
                    return NotFound();
                }
                return Ok(movies_);


            }
        }

        /// <summary>
        /// Add movie to route
        /// </summary>
        /// <param name="route_movie">Custom object type "Route_movie".</param>
        /// <returns>NoContent.</returns>
        [HttpPost]
        public async Task<IActionResult> PostRouteMovie([FromBody] Route_movie route_movie)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                db.Route_movie.Add(route_movie);
                await db.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}