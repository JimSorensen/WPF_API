using Microsoft.AspNetCore.Mvc;
using WPF_RestfulAPI.Services;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SalaryController : ControllerBase
	{
		private SalaryService _salaryService;

		public SalaryController(SalaryService salaryService)
		{
			_salaryService = salaryService;
		}

		[HttpGet("get-all-salaries")]
		public IActionResult GetAllSalaries()
		{
			var Allsalary = _salaryService.GetAllSalaries();
			return Ok(Allsalary);
		}

		[HttpPut("add-salary")]
		public IActionResult AddSalary([FromBody] SalaryVM salary)
		{
			_salaryService.AddSalary(salary);
			return Ok();
		}

		[HttpGet("get-salary-by-id/{id}")]
		public IActionResult GetSalaryById(int id)
		{
			var salary = _salaryService.GetSalaryById(id);
			return Ok(salary);
		}

		[HttpPut("update-salary-by-id/{id}")]
		public IActionResult UpdateSalaryById(int id, [FromBody] SalaryVM salary)
		{
			var _updateSalary = _salaryService.UpdateSalaryById(id, salary);
			return Ok(_updateSalary);
		}

		[HttpDelete("delete-salary-by-id/{id}")]
		public IActionResult DeleteSalaryById(int id)
		{
			_salaryService.DeleteSalaryById(id);
			return Ok();
		}
	}
}