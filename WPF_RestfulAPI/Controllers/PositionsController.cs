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

		[HttpGet("get-all-positions")]
		public IActionResult GetAllPositions()
		{
			var allPositions = _positionService.GetAllPositions();
			return Ok(allPositions);
		}

		[HttpPost("add-position")]
		public IActionResult AddPosition([FromBody] PositionVM position)
		{
			_positionService.AddPosition(position);
			return Ok();
		}

		[HttpGet("get-position-by-id/{id}")]
		public IActionResult GetPositionById(int id)
		{
			var position = _positionService.GetPositionById(id);
			return Ok(position);
		}

		[HttpPut("update-position-by-id/{id}")]
		public IActionResult UpdatePositionById(int id, [FromBody] PositionVM position)
		{
			var _updatePosition = _positionService.UpdatePositionById(id, position);
			return Ok(_updatePosition);
		}

		[HttpDelete("delete-position-by-id/{id}")]
		public IActionResult DeletePositionById(int id)
		{
			_positionService.DeletePositionById(id);
			return Ok();
		}
	}
}