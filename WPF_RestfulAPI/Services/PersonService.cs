using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
				Name = person.Name,
				Age = person.Age,
				Adress = person.Adress,
				Email = person.Email				
			};
			_context.Persons.Add(_person);
			_context.SaveChanges();
		}

		public PersonVM GetPersonById(int personId)
		{
			var _person = _context.Persons.Where(n => n.Id == personId)
				.Select(person => new PersonVM()
				{
					Name = person.Name,
					Age = person.Age,
					Adress = person.Adress,
					Email = person.Email

				}).FirstOrDefault();
			return _person;
		}

		public Person UpdatePersonById(int personId, PersonVM person)
		{
			var _person = _context.Persons.FirstOrDefault(n => n.Id == personId);
			if (_person != null)
			{
				_person.Name = person.Name;
				_person.Age = person.Age;
				_person.Adress = person.Adress;
				_person.Email = person.Email;
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
