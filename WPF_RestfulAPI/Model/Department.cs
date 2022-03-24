using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

		public virtual ICollection<Person> Persons { get; set; }
	}
}
