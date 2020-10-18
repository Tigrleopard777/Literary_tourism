/*
 * RouteSpectacle Controller
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
    public class RouteSpectacleController : ControllerBase
    {
        private readonly LiteraryTourismContext _context;

        public RouteSpectacleController(LiteraryTourismContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Get list of spectacles associated with a route by id of the route.
        /// </summary>
        /// <param name="id">The unique route id.</param>
        /// <returns>List of spectacles associated with a route.</returns>
        [HttpGet]
        public async Task<IActionResult> GetRouteSpectacle(int id)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (Request.Query.ContainsKey("id"))
                {
                    id = Convert.ToInt32((Request.Query.FirstOrDefault(p => p.Key == "id").Value));
                }


                var spectacles_ = (from spectacles in db.Set<Spectacles>()
                                join route_spectacle in db.Set<Route_spectacle>()
                                on spectacles.Id_spectacle equals route_spectacle.Id_spectacle
                                join theaters in db.Set<Theaters>()
                                on spectacles.Id_theater equals theaters.Id_theater
                                where route_spectacle.Id_route.Equals(id)
                                select new
                                {
                                    Id_spectacle = spectacles.Id_spectacle,
                                    Id_theater = spectacles.Id_theater,
                                    Spectacle_title = spectacles.Spectacle_title,
                                    Director = spectacles.Director,
                                    Spectacle_type = spectacles.Spectacle_type,
                                    Spectacle_link = spectacles.Spectacle_link,
                                    Spectacle_description = spectacles.Spectacle_description,
                                    Spectacle_rating = spectacles.Spectacle_rating,
                                    Id_Theater = theaters.Id_theater,
                                    Theater_name = theaters.Theater_name,
                                    Theater_site = theaters.Theater_site,
                                    Theater_description = theaters.Theater_description,
                                    Theater_address = theaters.Theater_address,
                                    Latitude = theaters.Latitude,
                                    Longitude = theaters.Longitude
                                }).ToList();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (spectacles_ == null)
                {
                    return NotFound();
                }
                return Ok(spectacles_);


            }
        }


        /// <summary>
        /// Add spectacle to route
        /// </summary>
        /// <param name="route_spectacle">Custom object type "Route_spectacle".</param>
        /// <returns>NoContent.</returns>
        [HttpPost]
        public async Task<IActionResult> PostRouteSpectacle([FromBody] Route_spectacle route_spectacle)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                db.Route_spectacle.Add(route_spectacle);
                await db.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}