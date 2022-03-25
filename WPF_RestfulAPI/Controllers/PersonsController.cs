using Microsoft.AspNetCore.Mvc;
using WPF_RestfulAPI.Services;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonsController : ControllerBase
	{
		public PersonService _personService;

		public PersonsController(PersonService personService)
		{
			_personService = personService;
		}

		[HttpGet("get-all-persons")]
		public IActionResult GetAllPersons()
		{
			var allPersons = _personService.GetAllPersons();
			return Ok(allPersons);
		}

		[HttpPost("add-person")]
		public IActionResult AddPerson([FromBody] PersonVM person)
		{
			_personService.AddPerson(person);
			return Ok();
		}

		[HttpGet("get-persons-by-id/{id}")]
		public IActionResult GetPersonById(int id)
		{
			var person = _personService.GetPersonById(id);
			return Ok(person);
		}

		[HttpPut("update-person-by-id/{id}")]
		public IActionResult UpdatePersonById(int id, [FromBody] PersonVM person)
		{
			var _updatePerson = _personService.UpdatePersonById(id, person);
			return Ok(_updatePerson);
		}

		[HttpDelete("delete-person-by-id/{id}")]
		public IActionResult DeletePersonById(int id)
		{
			_personService.DeletePersonById(id);
			return Ok();
		}
	}
}