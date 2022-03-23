using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Services;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PositionsController : ControllerBase
	{
		private PositionService _positionService;

		public PositionsController(PositionService positionService)
		{
			_positionService = positionService;
		}

		[HttpPost("add-position")]
		public IActionResult AddPosition([FromBody] PositionVM position)
		{
			_positionService.AddPosition(position);
			return Ok();
		}
	}
}
