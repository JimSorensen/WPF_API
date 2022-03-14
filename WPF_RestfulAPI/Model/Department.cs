using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_RestfulAPI.Model
{
	public class Department
	{
		[Key]
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }

		public virtual ICollection<Position> Positions { get; set; }
	}
}
