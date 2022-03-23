using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_RestfulAPI.Model
{
	public class PersonDetail
	{
		public int Id { get; set; }
		public string PersonCity { get; set; }
		public DateTime BirthDay { get; set; }

		[ForeignKey("Person")]
		public int PersonId { get; set; }
		public Person Person { get; set; }
	}
}

//[DataType(DataType.Date)]
//[DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
