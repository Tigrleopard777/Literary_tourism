/*
 * Users Controller
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
    public class UsersController : ControllerBase
    {
        private readonly LiteraryTourismContext db;

        public UsersController(LiteraryTourismContext context)
        {
            db = context;
        }

        /// <summary>
        /// Get user by login and password.
        /// </summary>
        /// <param name="log">User login.</param>
        /// <param name="pass">User password.</param>
        /// <returns>Custom object type "Users".</returns>
        [HttpGet]
        public async Task<IActionResult> GetUser(string log=" ", string pass=" ")
        {
            Users user = new Users();
            if (Request.Query.ContainsKey("log") && Request.Query.ContainsKey("pass"))
            {
                log = (Request.Query.FirstOrDefault(p => p.Key == "log").Value);
                pass = (Request.Query.FirstOrDefault(p => p.Key == "pass").Value);
            }
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var user1 = (from users in db.Set<Users>()
                             where users.Login == log &&                        
                             users.Password==pass
                             select users).ToList();

                if (user1 == null)
                {
                    return NotFound();
                }

                return Ok(user1);
            //}
        }

        /// <summary>
        /// Add new user.
        /// </summary>
        /// <param name="user">Custom object type "Users".</param>
        /// <returns>Added user.</returns>
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] Users user)
        {
            //using (LiteraryTourismContext db = new LiteraryTourismContext())
            //{
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return CreatedAtAction(nameof(GetUser), new { log=user.Login, pass=user.Password }, user);
            //}
        }


    }
}