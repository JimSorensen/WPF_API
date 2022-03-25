using System;

namespace WPF_RestfulAPI.Model
{
	public class PersonALL
	{
		//Person
		public int Id { get; set; }

		public string Name { get; set; }
		public string SurName { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Adress { get; set; }

		public string PositionName { get; set; }
		public string DepartmentName { get; set; }
		public int Amount { get; set; }
		public string PersonCity { get; set; }
		public DateTime BirthDay { get; set; }
		public DateTimeOffset CreateDate { get; init; }
	}
}