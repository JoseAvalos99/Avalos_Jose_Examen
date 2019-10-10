using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalos_Jose_Examen.Model.Model;
using Avalos_Jose_Examen.Resources;
using Avalos_Jose_Examen.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avalos_Jose_Examen.Controllers
{
    [Produces("application/json")]
    [Route("api/Contact")]
    public class ContactController : Controller
    {

		private readonly IContactService _contactService;
		public ContactController(IContactService contactService)
		{
			this._contactService = contactService;
		}
		// GET: api/Contact
        [HttpGet]
        public IActionResult Get()
        {
			try
			{
				return Ok(_contactService.GetContacts());
			}
			catch (Exception)
			{
				return BadRequest(Messages.ContactsGetError);
			}
        }

        // GET: api/Contact/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
			try
			{
				return Ok(_contactService.GetContactById(id));
			}
			catch (Exception)
			{
				return BadRequest(Messages.ContactsGetError);
			}
        }
        
        // POST: api/Contact
        [HttpPost]
        public ActionResult Post([FromBody] Contact contactValue)
        {
			try
			{
				if (!ModelState.IsValid)
					return BadRequest(Messages.ModelError);
				return Ok(_contactService.AddContact(contactValue));
			}
			catch (Exception)
			{
				return BadRequest(Messages.ContactsGetError);
			}
        }
        
        // PUT: api/Contact/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Contact contactValue)
        {
			try
			{
				if (!ModelState.IsValid)
					return BadRequest(Messages.ModelError);
				return Ok(_contactService.EditContact(id, contactValue));
			}
			catch (Exception)
			{
				return BadRequest(Messages.ContactsGetError);
			}
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
