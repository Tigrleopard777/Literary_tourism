/*
 * PlaceWork Controller
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
    public class PlaceWorkController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public PlaceWorkController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of places with a search by place name, name of the writer with whom the place is associated
        /// and the name of the work with which it is associated.
        /// </summary>
        /// <param name="place_name">Place name.</param>
        /// <param name="name">Full name of the writer.</param>
        /// <param name="work_name">Title of the work.</param>
        /// <returns>List of places.</returns>
        [HttpGet]
        public async Task<IActionResult> GetPlaces(string place_name = "", string name = "", string work_name="")
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
                if (Request.Query.ContainsKey("work_name"))
                {
                    work_name = (Request.Query.FirstOrDefault(p => p.Key == "work_name").Value);
                }

                var places_ = (from places in db.Set<Places>()
                               join place_work in db.Set<Place_work>()
                               on places.Id_place equals place_work.Id_place
                               join works in db.Set<Works>()
                               on place_work.Id_work equals works.Id_work
                               join writers in db.Set<Writers>()
                               on works.Id_writer equals writers.Id_writer
                               where places.Place_name.Contains(place_name) &&
                               writers.Full_name.Contains(name) &&
                               works.Work_name.Contains(work_name)
                               select new
                               {
                                   Id_place = places.Id_place,
                                   Place_name = places.Place_name,
                                   Place_description = places.Place_description,
                                   Place_rating = places.Place_rating,
                                   Place_address = places.Place_address,
                                   Latitude = places.Latitude,
                                   Longitude = places.Longitude,
                                   Id_work = works.Id_work,
                                   Id_writer = works.Id_writer,
                                   Id_genre = works.Id_genre,
                                   Work_name = works.Work_name,
                                   Work_link = works.Work_link,
                                   Work_description = works.Work_description,
                                   Work_rating = works.Work_rating,
                                   Excerpt_text=place_work.Excerpt_text,
                                   Id_Writer = writers.Id_writer,
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