/*
 * Works Controller
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
    public class WorksController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public WorksController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of works with a search by work name and name of the writer with whom the work is associated.
        /// </summary>
        /// <param name="work_name">Title of the work.</param>
        /// <param name="name">Full name of the writer.</param>
        /// <returns>List of works.</returns>
        [HttpGet]
        public async Task<IActionResult> GetWorks(string work_name = "", string name = "")
        {
            Works _works = new Works();
            if (Request.Query.ContainsKey("work_name"))
            {
                work_name = (Request.Query.FirstOrDefault(p => p.Key == "work_name").Value);
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

                var works_ = (from works in db.Set<Works>()
                               join genre_of_literature in db.Set<Genres_of_literature>()
                               on works.Id_genre equals genre_of_literature.Id_genre
                               join writers in db.Set<Writers>()
                               on works.Id_writer equals writers.Id_writer
                               where writers.Full_name.Contains(name) &&
                               works.Work_name.Contains(work_name)
                               select new
                               {
                                   Id_work = works.Id_work,
                                   Id_writer = works.Id_writer,
                                   Id_genre = works.Id_genre,
                                   Work_name = works.Work_name,
                                   Work_link = works.Work_link,
                                   Work_description = works.Work_description,
                                   Work_rating = works.Work_rating,
                                   genre_name = genre_of_literature.Genre_name,
                                   Id_Writer = writers.Id_writer,
                                   Full_name = writers.Full_name,
                                   Date_of_birth = writers.Date_of_birth,
                                   Date_of_death = writers.Date_of_death,
                                   Place_of_birth = writers.Place_of_birth,
                                   Place_of_death = writers.Place_of_death,
                                   Biography = writers.Biography
                               }).ToList();

                if (works_ == null)
                {
                    return NotFound();
                }

                return Ok(works_);
            //}
        }
    }
}