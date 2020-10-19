/*
 * Places Controller
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
    public class PlacesController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public PlacesController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of places with a search by place name and name of the writer with whom the film is associated.
        /// </summary>
        /// <param name="place_name">Place name.</param>
        /// <param name="name">Full name of the writer.</param>
        /// <returns>List of places.</returns>
        [HttpGet]
        public async Task<IActionResult> GetPlaces(string place_name = "", string name = "")
        {
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (Request.Query.ContainsKey("place_name"))
                {
                    place_name = (Request.Query.FirstOrDefault(p => p.Key == "place_name").Value);
                }
                if (Request.Query.ContainsKey("name"))
                {
                    name = (Request.Query.FirstOrDefault(p => p.Key == "name").Value);
                }

                var places_ = (from places in db.Set<Places>()
                               join place_writer in db.Set<Place_writer>()
                               on places.Id_place equals place_writer.Id_place
                               join writers in db.Set<Writers>()
                               on place_writer.Id_writer equals writers.Id_writer
                               where places.Place_name.Contains(place_name) &&
                               writers.Full_name.Contains(name)
                               select new
                               {
                                   Id_place = places.Id_place,
                                   Place_name = places.Place_name,
                                   Place_description = places.Place_description,
                                   Place_rating = places.Place_rating,
                                   Place_address = places.Place_address,
                                   Latitude = places.Latitude,
                                   Longitude = places.Longitude,
                                   Relation_description = place_writer.Relation_description,
                                   Id_writer = writers.Id_writer,
                                   Full_name = writers.Full_name,
                                   Date_of_birth = writers.Date_of_birth,
                                   Date_of_death = writers.Date_of_death,
                                   Place_of_birth = writers.Place_of_birth,
                                   Place_of_death = writers.Place_of_death,
                                   Biography = writers.Biography

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


            //}
        }
    }
}