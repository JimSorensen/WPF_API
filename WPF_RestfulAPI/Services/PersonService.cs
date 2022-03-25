using System.Collections.Generic;
using System.Linq;
using WPF_RestfulAPI.Model;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Services
{
	public class PersonService
	{
		private readonly APIDbContext _context;

		public PersonService(APIDbContext context)
		{
			_context = context;
		}

		public List<Person> GetAllPersons() => _context.Persons.ToList();

		public void AddPerson(PersonVM person)
		{
			var _person = new Person()
			{
				FirstName = person.FirstName,
				Surname = person.Surname,
				Age = person.Age,
				Email = person.Email,
				Password = person.Password,
				Adress = person.Adress
			};
			_context.Persons.Add(_person);
			_context.SaveChanges();
		}

		public PersonVM GetPersonById(int personId)
		{
			var _person = _context.Persons.Where(n => n.Id == personId)
				.Select(person => new PersonVM()
				{
					FirstName = person.FirstName,
					Surname = person.Surname,
					Age = person.Age,
					Email = person.Email,
					Password = person.Password,
					Adress = person.Adress
				}).FirstOrDefault();
			return _person;
		}

		public Person UpdatePersonById(int personId, PersonVM person)
		{
			var _person = _context.Persons.FirstOrDefault(n => n.Id == personId);
			if (_person != null)
			{
				_person.FirstName = person.FirstName;
				_person.Surname = person.Surname;
				_person.Age = person.Age;
				_person.Email = person.Email;
				_person.Password = person.Password;
				_person.Adress = person.Adress;

				_context.SaveChanges();
			}
			return _person;
		}

		public void DeletePersonById(int personId)
		{
			var _person = _context.Persons.FirstOrDefault(n => n.Id == personId);
			if (_person != null)
			{
				_context.Persons.Remove(_person);
				_context.SaveChanges();
			}
		}
	}
}