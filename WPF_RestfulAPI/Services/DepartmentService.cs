using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Model;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Services
{
	public class DepartmentService
	{
		private readonly APIDbContext _context;

		public DepartmentService(APIDbContext context)
		{
			_context = context;
		}

		public List<Department> GetAllDepartments() => _context.Departments.ToList();

		public void AddDepartment(DepartmentVM department)
		{
			var _department = new Department()
			{
				DepartmentName = department.DepartmentName,
				CreateDate = department.CreateDate,
				Positions = department.Positions
			};
			_context.Departments.Add(_department);
			_context.SaveChanges();
		}

		public DepartmentVM GetDepartmentById(int departmentId)
		{
			var _department = _context.Departments.Where(n => n.DepartmentId == departmentId)
				.Select(department => new DepartmentVM()
				{
					DepartmentName = department.DepartmentName,
					CreateDate = department.CreateDate
					
				}).FirstOrDefault();
			return _department;
		}
	}
}
