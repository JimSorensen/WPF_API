using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Model;
using WPF_RestfulAPI.Services;
using WPF_RestfulAPI.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

	}
}
