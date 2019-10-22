using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Avalos_Jose_Examen.Resources;
using Avalos_Jose_Examen.Service.Service;
using Avalos_Jose_Examen.Model.Model;

namespace Avalos_Jose_Examen.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			this._userService = userService;
		}

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
			try
			{
				return Ok(_userService.GetUsers());
			}
			catch (Exception)
			{
				return BadRequest(Messages.UsersGetError);
			}
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
			try
			{
				return Ok(_userService.GetUsers());
			}
			catch (Exception)
			{
				return BadRequest(Messages.UsersGetError);
			}
		}
        
        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User userValue)
        {
			try
			{
				_userService.AddUser(userValue);
				return Ok(200);
			}
			catch (Exception)
			{
				return Ok(Messages.ModelError);
			}
        }
        
        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
