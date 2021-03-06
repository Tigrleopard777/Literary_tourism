﻿/*
 * MarkOfRoute Controller
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
    public class MarkOfRouteController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public MarkOfRouteController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Add new mark for route.
        /// </summary>
        /// <param name="mark">Custom object type "Mark_of_route".</param>
        /// <returns>NoContetnt.</returns>
        [HttpPost]
        public async Task<IActionResult> PostMark([FromBody] Mark_of_route mark)
        {
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var mark_ = (from Mark in db.Set<Mark_of_route>()
                             where Mark.Id_route.Equals(mark.Id_route) &&
                             Mark.Id_user.Equals(mark.Id_user)
                             select new
                             {
                                 Id_mark = Mark.Id_mark
                             }).ToList();
                if (mark_.Count != 0)
                {
                    mark.Id_mark = mark_[0].Id_mark;
                    db.Entry(mark).State = EntityState.Modified;
                    try
                    {
                        await db.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                    }
                }
                else
                {
                    db.Mark_of_route.Add(mark);
                    await db.SaveChangesAsync();
                }
                return NoContent();
            //}
        }
    }
}