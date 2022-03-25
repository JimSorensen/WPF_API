using System.Collections.Generic;
using System.Linq;
using WPF_RestfulAPI.Model;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Services
{
	public class SalaryService
	{
		private APIDbContext _context;

		public SalaryService(APIDbContext context)
		{
			_context = context;
		}

		public List<Salary> GetAllSalaries() => _context.Salaries.ToList();

		public void AddSalary(SalaryVM salary)
		{
			var _salary = new Salary()
			{
				Amount = salary.Amount
			};
			_context.Salaries.Add(_salary);
			_context.SaveChanges();
		}

		public SalaryVM GetSalaryById(int salaryId)
		{
			var _salary = _context.Salaries.Where(n => n.SalaryId == salaryId)
				.Select(salary => new SalaryVM()
				{
					Amount = salary.Amount
				}).FirstOrDefault();
			return _salary;
		}

		public Salary UpdateSalaryById(int salaryId, SalaryVM salary)
		{
			var _salary = _context.Salaries.FirstOrDefault(n => n.SalaryId == salaryId);
			if (_salary != null)
			{
				_salary.Amount = salary.Amount;
				_context.SaveChanges();
			}
			return _salary;
		}

		public void DeleteSalaryById(int salaryId)
		{
			var _salary = _context.Salaries.FirstOrDefault(n => n.SalaryId == salaryId);
			if (_salary != null)
			{
				_context.Salaries.Remove(_salary);
				_context.SaveChanges();
			}
		}
	}
}