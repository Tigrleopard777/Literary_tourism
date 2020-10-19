/*
 * Theaters Controller
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
    public class TheatersController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public TheatersController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of theaters with a search by theater name and spectacle title.
        /// </summary>
        /// <param name="theater_name">Theater name.</param>
        /// <param name="spectacle_title">Title of the spectacle.</param>
        /// <returns>List of Theaters.</returns>
        [HttpGet]
        public async Task<IActionResult> GetTheaters(string theater_name = "", string spectacle_title = "")
        {
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (Request.Query.ContainsKey("theater_name"))
                {
                    theater_name = (Request.Query.FirstOrDefault(p => p.Key == "theater_name").Value);
                }
                if (Request.Query.ContainsKey("spectacle_title"))
                {
                    spectacle_title = (Request.Query.FirstOrDefault(p => p.Key == "spectacle_title").Value);

                    var theaters_ = (from theaters in db.Set<Theaters>()
                                     join spectacles in db.Set<Spectacles>()
                                     on theaters.Id_theater equals spectacles.Id_theater
                                     where theaters.Theater_name.Contains(theater_name) &&
                                     spectacles.Spectacle_title.Contains(spectacle_title)
                                     select new
                                     {
                                         Id_theater = theaters.Id_theater,
                                         Theater_name = theaters.Theater_name,
                                         Theater_site = theaters.Theater_site,
                                         Theater_description = theaters.Theater_description,
                                         Theater_address = theaters.Theater_address,
                                         Latitude = theaters.Latitude,
                                         Longitude = theaters.Longitude

                                     }).Distinct().ToList();

                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    if (theaters_ == null)
                    {
                        return NotFound();
                    }
                    return Ok(theaters_);
                }
                else
                {

                    var theaters__ = (from theaters in db.Set<Theaters>()
                                      where theaters.Theater_name.Contains(theater_name)
                                      select new
                                      {
                                          Id_theater = theaters.Id_theater,
                                          Theater_name = theaters.Theater_name,
                                          Theater_site = theaters.Theater_site,
                                          Theater_description = theaters.Theater_description,
                                          Theater_address = theaters.Theater_address,
                                          Latitude = theaters.Latitude,
                                          Longitude = theaters.Longitude,

                                      }).ToList();

                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    if (theaters__ == null)
                    {
                        return NotFound();
                    }
                    return Ok(theaters__);
                }


            //}
        }
    }
}