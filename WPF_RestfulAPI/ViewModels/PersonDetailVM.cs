using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_RestfulAPI.ViewModels
{
	public class PersonDetailVM
	{
		public string PersonCity { get; set; }
		public DateTime BirthDay { get; set; }

		public DateTimeOffset CreateDate { get; init; }
	}
}
