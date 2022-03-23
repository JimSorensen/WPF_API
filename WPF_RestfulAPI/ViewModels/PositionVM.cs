using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Model;

namespace WPF_RestfulAPI.ViewModels
{
	public class PositionVM
	{
		public string Name { get; set; }

		public virtual List<Person> Persons { get; set; }

		public int DepartmentId { get; set; }
		public Department Department { get; set; }
	}
}
