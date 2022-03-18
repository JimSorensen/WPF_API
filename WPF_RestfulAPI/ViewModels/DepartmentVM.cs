using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Model;

namespace WPF_RestfulAPI.ViewModels
{
	public class DepartmentVM
	{
		public string DepartmentName { get; set; }

		public DateTimeOffset CreateDate { get; init; }
		public virtual List<Position> Positions { get; set; }
	}
}
