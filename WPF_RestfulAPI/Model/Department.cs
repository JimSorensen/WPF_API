using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WPF_RestfulAPI.Model
{
	public class Department
	{
		public Department()
		{
			Persons = new HashSet<Person>();
		}

		[Key]
		public int DepartmentId { get; set; }

		public string DepartmentName { get; set; }

		public ICollection<Person> Persons { get; set; }
	}
}