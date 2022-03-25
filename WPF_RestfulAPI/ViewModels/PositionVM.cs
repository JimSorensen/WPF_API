using System.Collections.Generic;
using WPF_RestfulAPI.Model;

namespace WPF_RestfulAPI.ViewModels
{
	public class PositionVM
	{
		public string PositionName { get; set; }

		public virtual List<Person> Persons { get; set; }

		public int DepartmentId { get; set; }
		public Department Department { get; set; }
	}
}