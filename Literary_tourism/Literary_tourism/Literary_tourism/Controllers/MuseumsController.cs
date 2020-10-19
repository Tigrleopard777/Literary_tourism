/*
 * Museums Controller
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
    public class MuseumsController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public MuseumsController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of museums with a search by museum name and name of the writer with whom the film is associated.
        /// </summary>
        /// <param name="museum_title">Museum title.</param>
        /// <param name="name">Full name of the writer.</param>
        /// <returns>List of museums.</returns>
        [HttpGet]
        public async Task<IActionResult> GetMuseums(string museum_name ="", string name = "")
        {
            Museums _museums = new Museums();
            if (Request.Query.ContainsKey("museum_name"))
            {
                museum_name = (Request.Query.FirstOrDefault(p => p.Key == "museum_name").Value);
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

                var museums_ = (from museums in db.Set<Museums>()
                                join museum_writer in db.Set<Museum_writer>()
                                on museums.Id_museum equals museum_writer.Id_museum
                                join writers in db.Set<Writers>()
                                on museum_writer.Id_writer equals writers.Id_writer
                                where writers.Full_name.Contains(name) &&
                                museums.Museum_name.Contains(museum_name)
                                select new { Id_museum=museums.Id_museum, Museum_name=museums.Museum_name,
                                Museum_site=museums.Museum_site, Museum_description=museums.Museum_description,
                                Museum_rating=museums.Museum_rating, Museum_address=museums.Museum_address,
                                Latitude=museums.Latitude, Longitude=museums.Longitude,
                                Id_writer=writers.Id_writer, Full_name=writers.Full_name,
                                Date_of_birth=writers.Date_of_birth, Date_of_death=writers.Date_of_death,
                                Place_of_birth=writers.Place_of_birth, Place_of_death=writers.Place_of_death,
                                Biography=writers.Biography}).ToList();

                if (museums_ == null)
                {
                    return NotFound();
                }

                return Ok(museums_);
            //}
        }
    }
}