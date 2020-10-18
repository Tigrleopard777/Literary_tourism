/*
 * Routes Controller
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
    public class RoutesController : ControllerBase
    {
        private readonly LiteraryTourismContext _context;

        public RoutesController(LiteraryTourismContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get list of routes with a search by route name, name of the writer with whom the route is associated 
        /// and nick of the user creates this route.
        /// </summary>
        /// <param name="route_name">Title of the route.</param>
        /// <param name="name">Full name of the writer.</param>
        /// <param name="nick">Nick of the user created this route.</param>
        /// <returns>List of routes.</returns>
        [HttpGet]
        public async Task<IActionResult> GetRoutes(string route_name = "", string name = "", string nick="")
        {
            Movies _movies = new Movies();
            if (Request.Query.ContainsKey("route_name"))
            {
                route_name = (Request.Query.FirstOrDefault(p => p.Key == "route_name").Value);
            }
            if (Request.Query.ContainsKey("name"))
            {
                name = (Request.Query.FirstOrDefault(p => p.Key == "name").Value);
            }
            if (Request.Query.ContainsKey("nick"))
            {
                nick = (Request.Query.FirstOrDefault(p => p.Key == "nick").Value);
            }
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var routes_ = (from routes in db.Set<Routes>()
                              join users in db.Set<Users>()
                              on routes.Id_user equals users.Id_user
                              join writers in db.Set<Writers>()
                              on routes.Id_writer equals writers.Id_writer
                              where writers.Full_name.Contains(name) &&
                              routes.Route_name.Contains(route_name) &&
                              users.Nick.Contains(nick)
                              select new
                              {
                                  Id_route = routes.Id_route,
                                  Route_name = routes.Route_name,
                                  Id_user = routes.Id_user,
                                  Id_writer = routes.Id_writer,
                                  Date = routes.Date,
                                  Route_description = routes.Route_description,
                                  Route_rating = routes.Route_rating,
                                  Full_name = writers.Full_name,
                                  Nick = users.Nick
                              }).ToList();

                if (routes_ == null)
                {
                    return NotFound();
                }

                return Ok(routes_);
            }
        }

        /// <summary>
        /// Add new routed.
        /// </summary>
        /// <param name="route">Custom object type "Routes"</param>
        /// <returns>List of routes, where name of route like name of this route.</returns>
        [HttpPost]
        public async Task<IActionResult> PostRoute([FromBody] Routes route)
        {
            using (LiteraryTourismContext db = new LiteraryTourismContext())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                db.Routes.Add(route);
                await db.SaveChangesAsync();
                return CreatedAtAction(nameof(GetRoutes), new { route_name = route.Route_name}, route);
            }
        }
    }
}