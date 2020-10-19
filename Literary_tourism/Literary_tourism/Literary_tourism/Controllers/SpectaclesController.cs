/*
 * Spectacles Controller
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
    public class SpectaclesController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public SpectaclesController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of spectacles with a search by theater name, spectacle title 
        /// and name of the writer with whom the spectacle is associated.
        /// </summary>
        /// <param name="theater_name">Theater name.</param>
        /// <param name="writer_name">Full name of the writer.</param>
        /// <param name="spectacle_title">Title of the spectacle.</param>
        /// <returns>List of spectacles.</returns>
        [HttpGet]
        public async Task<IActionResult> GetSpectacles(string theater_name = "", string spectacle_title = "", string writer_name="")
        {
   
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if ((Request.Query.ContainsKey("theater_name")))
                {
                    theater_name = (Request.Query.FirstOrDefault(p => p.Key == "theater_name").Value);
                }
                if ((Request.Query.ContainsKey("spectacle_title")))
                {
                    spectacle_title = (Request.Query.FirstOrDefault(p => p.Key == "spectacle_title").Value);
                }
                if ((Request.Query.ContainsKey("writer_name")))
                {
                    writer_name = (Request.Query.FirstOrDefault(p => p.Key == "writer_name").Value);

                    var spectacles_ = (from spectacles in db.Set<Spectacles>()
                                       join theaters in db.Set<Theaters>()
                                       on spectacles.Id_theater equals theaters.Id_theater
                                       join spectacle_writer in db.Set<Spectacle_writer>()
                                       on spectacles.Id_spectacle equals spectacle_writer.Id_spectacle
                                       join writers in db.Set<Writers>()
                                       on spectacle_writer.Id_writer equals writers.Id_writer
                                       where theaters.Theater_name.Contains(theater_name) &&
                                       spectacles.Spectacle_title.Contains(spectacle_title) &&
                                       writers.Full_name.Contains(writer_name)
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
                                           Longitude = theaters.Longitude,

                                       }).Distinct().ToList();

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
                else
                {
                    var spectacles_ = (from spectacles in db.Set<Spectacles>()
                                       join theaters in db.Set<Theaters>()
                                       on spectacles.Id_theater equals theaters.Id_theater
                                       where theaters.Theater_name.Contains(theater_name) &&
                                       spectacles.Spectacle_title.Contains(spectacle_title)
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
                                           Longitude = theaters.Longitude,

                                       }).Distinct().ToList();

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


            //}
        }
    }
}