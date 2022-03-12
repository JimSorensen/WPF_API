using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_RestfulAPI.Model
{
	public class Position
	{
		public Position()
		{
			Persons = new HashSet<Person>();
		}

		[Key]
		public int PositionId { get; set; }
		public int Name { get; set; }

		public virtual ICollection<Person> Persons { get; set; }
	}
}
