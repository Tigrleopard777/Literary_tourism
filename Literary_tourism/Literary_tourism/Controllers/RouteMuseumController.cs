/*
 * RouteMuseum Controller
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
    public class RouteMuseumController : ControllerBase
    {
        private readonly LiteraryTourismContext _context;

        public RouteMuseumController(LiteraryTourismContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get list of museums associated with a route by id of the route.
        /// </summary>
        /// <param name="id">The unique route id.</param>
        /// <returns>List of musseums associated with a route.</returns>
        [HttpGet]
        public async Task<IActionResult> GetRouteMuseum(int id)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (Request.Query.ContainsKey("id"))
                {
                    id = Convert.ToInt32((Request.Query.FirstOrDefault(p => p.Key == "id").Value));
                }


                var museums_ = (from museums in db.Set<Museums>()
                               join route_museum in db.Set<Route_museum>()
                               on museums.Id_museum equals route_museum.Id_museum
                               where route_museum.Id_route.Equals(id)
                               select new
                               {
                                   Id_museum = museums.Id_museum,
                                   Museum_name = museums.Museum_name,
                                   Museum_site = museums.Museum_site,
                                   Museum_description = museums.Museum_description,
                                   Museum_rating = museums.Museum_rating,
                                   Museum_address = museums.Museum_address,
                                   Latitude = museums.Latitude,
                                   Longitude = museums.Longitude
                               }).ToList();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (museums_ == null)
                {
                    return NotFound();
                }
                return Ok(museums_);


            }
        }

        /// <summary>
        /// Add museum to route
        /// </summary>
        /// <param name="route_museum">Custom object type "Route_museum".</param>
        /// <returns>NoContent.</returns>
        [HttpPost]
        public async Task<IActionResult> PostRouteMuseum([FromBody] Route_museum route_museum)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                db.Route_museum.Add(route_museum);
                await db.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}