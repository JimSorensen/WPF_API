﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WPF_RestfulAPI.Model
{
	public class Salary
	{
		public Salary()
		{
			Persons = new HashSet<Person>();
		}

		[Key]
		public int SalaryId { get; set; }

		public int Amount { get; set; }
		public virtual ICollection<Person> Persons { get; set; }
	}
}