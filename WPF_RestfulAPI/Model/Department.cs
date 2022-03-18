﻿using System;
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

		public DateTimeOffset CreateDate { get; init; }
		public virtual List<Position> Positions { get; set; }
	}
}
