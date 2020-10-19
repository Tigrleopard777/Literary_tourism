/*
 * PicturePlace Controller
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
    public class PicturePlaceController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public PicturePlaceController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get pictures for place by id.
        /// </summary>
        /// <param name="id">The unique place id.</param>
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
                                 join picture_place in db.Set<Picture_place>()
                                 on pictures.Id_picture equals picture_place.Id_picture
                                 where picture_place.Id_place.Equals(id)
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