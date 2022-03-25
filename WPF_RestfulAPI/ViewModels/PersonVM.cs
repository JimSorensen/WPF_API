using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

		
		public virtual PersonDetail PersonDetail { get; set; }
		//
	}
}