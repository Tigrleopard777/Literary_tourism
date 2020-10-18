/*
 * RoutePlace Controller
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
    public class RoutePlaceController : ControllerBase
    {
        private readonly LiteraryTourismContext _context;

        public RoutePlaceController(LiteraryTourismContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get list of places associated with a route by id of the route.
        /// </summary>
        /// <param name="id">The unique route id.</param>
        /// <returns>List of places associated with a route.</returns>
        [HttpGet]
        public async Task<IActionResult> GetRoutePlace(int id)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (Request.Query.ContainsKey("id"))
                {
                    id = Convert.ToInt32((Request.Query.FirstOrDefault(p => p.Key == "id").Value));
                }


                var places_ = (from places in db.Set<Places>()
                                join route_place in db.Set<Route_place>()
                                on places.Id_place equals route_place.Id_place
                                where route_place.Id_route.Equals(id)
                                select new
                                {
                                    Id_place = places.Id_place,
                                    Place_name = places.Place_name,
                                    Place_description = places.Place_description,
                                    Place_rating = places.Place_rating,
                                    Place_address = places.Place_address,
                                    Latitude = places.Latitude,
                                    Longitude = places.Longitude
                                }).ToList();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (places_ == null)
                {
                    return NotFound();
                }
                return Ok(places_);
            }
        }

        /// <summary>
        /// Add place to route
        /// </summary>
        /// <param name="route_place">Custom object type "Route_place".</param>
        /// <returns>NoContent.</returns>
        [HttpPost]
        public async Task<IActionResult> PostRoutePlace([FromBody] Route_place route_place)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                db.Route_place.Add(route_place);
                await db.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}