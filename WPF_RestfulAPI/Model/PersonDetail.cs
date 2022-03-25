using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF_RestfulAPI.Model
{
	public class PersonDetail
	{
		public int Id { get; set; }
		public string PersonCity { get; set; }
		public DateTime BirthDay { get; set; }
		public DateTimeOffset CreateDate { get; init; }

		[ForeignKey("Person")]
		public int PersonId { get; set; }

		public Person Person { get; set; }
	}
}