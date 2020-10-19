/*
 * Writers Controller
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
    public class WritersController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public WritersController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get list of writers with a search by writer full name.
        /// </summary>
        /// <param name="name">Full name of the writer.</param>
        /// <returns>List of writers.</returns>
        [HttpGet]
        public async Task<IActionResult> GetWriter(string name = "")
        {
            Writers writer = new Writers();
            if (Request.Query.ContainsKey("name"))
            {
                name =(Request.Query.FirstOrDefault(p => p.Key == "name").Value);
            }
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var writersdb = (from writers in db.Set<Writers>()
                             where writers.Full_name.Contains(name)
                             select writers).ToList();

                if (writersdb == null)
                {
                    return NotFound();
                }

                return Ok(writersdb);
            //}
        }
    }
}