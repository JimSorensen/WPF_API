using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_RestfulAPI.ViewModels
{
	public class DepartmentVM
	{
		public string DepartmentName { get; set; }

		public DateTimeOffset CreateDate { get; init; }
	}
}
