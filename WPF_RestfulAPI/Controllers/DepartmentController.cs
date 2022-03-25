using Microsoft.AspNetCore.Mvc;
using WPF_RestfulAPI.Services;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentController : ControllerBase
	{
		public DepartmentService _departmentService;

		public DepartmentController(DepartmentService departmentService)
		{
			_departmentService = departmentService;
		}

		[HttpGet("get-all-departments")]
		public IActionResult GetAllDepartments()
		{
			var allDepartments = _departmentService.GetAllDepartments();
			return Ok(allDepartments);
		}

		[HttpPost("add-department")]
		public IActionResult AddDepartment([FromBody] DepartmentVM department)
		{
			_departmentService.AddDepartment(department);
			return Ok();
		}

		[HttpGet("get-departments-by-id/{id}")]
		public IActionResult GetDepartmentById(int id)
		{
			var department = _departmentService.GetDepartmentById(id);
			return Ok(department);
		}

		[HttpPut("update-department-by-id/{id}")]
		public IActionResult UpdateDepartmentById(int id, [FromBody] DepartmentVM departmet)
		{
			var _updateDepartment = _departmentService.UpdateDepartmentById(id, departmet);
			return Ok(_updateDepartment);
		}

		[HttpDelete("delete-department-by-id/{id}")]
		public IActionResult DeleteDepartmentById(int id)
		{
			_departmentService.DeleteDepartmentById(id);
			return Ok();
		}
	}
}