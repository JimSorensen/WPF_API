using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Model;

namespace WPF_RestfulAPI.ViewModels
{
	public class PersonVM
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Adress { get; set; }

		[ForeignKey("Position")]
		public int PositionId { get; set; }
		public Position Position { get; set; }

		[ForeignKey("Salary")]
		public int SalaryId { get; set; }
		public Salary Salary { get; set; }

		public virtual PersonDetail PersonDetail { get; set; }
	}
}
