﻿/*
 * PictureTheater Controller
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
    public class PictureTheaterController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public PictureTheaterController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get pictures for theater by id.
        /// </summary>
        /// <param name="id">The unique theater id.</param>
        /// <returns>List of pictures.</returns>
        [HttpGet]
        public async Task<IActionResult> GetPictures(int id)
        {
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (Request.Query.ContainsKey("id"))
                {
                    id = Convert.ToInt32((Request.Query.FirstOrDefault(p => p.Key == "id").Value));
                }


                var pictures_ = (from pictures in db.Set<Pictures>()
                                 join picture_theater in db.Set<Picture_theater>()
                                 on pictures.Id_picture equals picture_theater.Id_picture
                                 where picture_theater.Id_theater.Equals(id)
                                 select new
                                 {
                                     Id_picture = pictures.Id_picture,
                                     Picture_name = pictures.Picture_name,
                                     Picture_link = pictures.Picture_link,
                                     Picture_type = pictures.Picture_type,
                                 }).ToList();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (pictures_ == null)
                {
                    return NotFound();
                }
                return Ok(pictures_);


            //}
        }
    }
}