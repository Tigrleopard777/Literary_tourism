/*
 * CommentMovie Controller
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
    public class CommentMovieController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public CommentMovieController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get comments for movie by id.
        /// </summary>
        /// <param name="id">The unique movie id.</param>
        /// <returns>List of comments.</returns>
        [HttpGet]
        public async Task<IActionResult> GetComments(int id)
        {
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (Request.Query.ContainsKey("id"))
                {
                    id = Convert.ToInt32((Request.Query.FirstOrDefault(p => p.Key == "id").Value));
                }


                var comments_ = (from comments in db.Set<Comment_movie>()
                                 join users in db.Set<Users>()
                                 on comments.Id_user equals users.Id_user
                                 where comments.Id_movie.Equals(id)
                                 select new
                                 {
                                     Id_comment = comments.Id_comment,
                                     Id_movie = comments.Id_movie,
                                     Id_user = comments.Id_user,
                                     Date = comments.Date,
                                     Time = comments.Time,
                                     Comment = comments.Comment,
                                     Edit_flag = comments.Edit_flag,
                                     Nick = users.Nick
                                 }).ToList();

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (comments_ == null)
                {
                    return NotFound();
                }
                return Ok(comments_);


           // }
        }

        /// <summary>
        /// Add new comment for movie by id.
        /// </summary>
        /// <param name="comment">Custom object type "Comment_movie".</param>
        /// <returns>List of comments.</returns>
        [HttpPost]
        public async Task<IActionResult> PostComment([FromBody] Comment_movie comment)
        {
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                db.Comment_movie.Add(comment);
                await db.SaveChangesAsync();
                return CreatedAtAction(nameof(GetComments), new { id = comment.Id_movie }, comment);
           // }
        }
    }
}