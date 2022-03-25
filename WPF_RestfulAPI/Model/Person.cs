using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF_RestfulAPI.Model
{
	public class Person //Kan have en position og en salary (Mange til en)
	{
		[Key]
		public int Id { get; set; }

		public string FirstName { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Adress { get; set; }

		[ForeignKey("Position")]                                                 // En position kan have mange personer
		public int PositionId { get; set; }
		public Position Position { get; set; }

		[ForeignKey("Salary")]                                                 // En Salary kan have mange personer
		public int SalaryId { get; set; }
		public Salary Salary { get; set; }

		public virtual PersonDetail PersonDetail { get; set; }   // En til en                // En PersonDetail kan kun have en person
	}
}