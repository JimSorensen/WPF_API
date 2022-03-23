using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Model;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Services
{
	public class PositionService
	{
		private APIDbContext _context;

		public PositionService(APIDbContext context)
		{
			_context = context;
		}

		public void AddPosition(PositionVM position)
		{
			var _position = new Position()
			{
				Name = position.Name,
				
			};
			_context.Positions.Add(_position);
			_context.SaveChanges();
		}
	}
}
