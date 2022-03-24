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

		public List<Position> GetAllPositions() => _context.Positions.ToList();

		public void AddPosition(PositionVM position)
		{
			var _position = new Position()
			{
				Name = position.Name				
			};
			_context.Positions.Add(_position);
			_context.SaveChanges();
		}

		public PositionVM GetPositionById(int positionId)
		{
			var _position = _context.Persons.Where(n => n.PositionId == positionId)
				.Select(position => new PositionVM()
				{
					Name = position.Name
					
				}).FirstOrDefault();

			return _position;
		}

		public Position UpdatePositionById(int positionId, PositionVM position)
		{
			var _position = _context.Positions.FirstOrDefault(n => n.PositionId == positionId);
			if (_position != null)
			{
				_position.Name = position.Name;		

				_context.SaveChanges();
			}
			return _position;
		}

		public void DeletePositionById(int positionId)
		{
			var _position = _context.Positions.FirstOrDefault(n => n.PositionId == positionId);
			if (_position != null)
			{
				_context.Positions.Remove(_position);
				_context.SaveChanges();
			}
		}
	}
}
