using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Model
{
	public class Position
	{
		public Position()
		{
			Persons = new HashSet<PersonVM>();
		}

		[Key]
		public int PositionId { get; set; }

		public string PositionName { get; set; }

		public ICollection<PersonVM> Persons { get; set; }

		[ForeignKey("Department")]
		public int DepartmentId { get; set; }

		public Department Department { get; set; }
	}
}