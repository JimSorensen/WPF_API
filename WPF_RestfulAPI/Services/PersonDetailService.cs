using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WPF_RestfulAPI.Model;
using WPF_RestfulAPI.ViewModels;

namespace WPF_RestfulAPI.Services
{
	public class PersonDetailService
	{
		private readonly APIDbContext _context;
		public PersonDetailService(APIDbContext context)
		{
			_context = context;
		}

		public List<PersonDetail> GetAllPersonDetails() => _context.PersonDetails.ToList();

		public void AddPersonDetails(PersonDetailVM personDetail)
		{
			var _personDetail = new PersonDetail()
			{
				PersonCity = personDetail.PersonCity,
				BirthDay = personDetail.BirthDay,
				CreateDate = personDetail.CreateDate,
			};
			_context.PersonDetails.Add(_personDetail);
			_context.SaveChanges();
		}

		public PersonDetailVM GetPersonDetailById(int personDetailId)
		{
			var _personDetails = _context.PersonDetails.Where(n => n.Id == personDetailId)
				.Select(personDetail => new PersonDetailVM()
				{
					PersonCity = personDetail.PersonCity,
					BirthDay = personDetail.BirthDay,
					CreateDate = personDetail.CreateDate

				}).FirstOrDefault();
			return _personDetails;
		}


		public PersonDetail UpdatePersonDetailsById(int personDetailsId, PersonDetailVM personDetail)
		{
			var _personDetails = _context.PersonDetails.FirstOrDefault(n => n.Id == personDetailsId);
			if (_personDetails != null)
			{
				_personDetails.PersonCity = personDetail.PersonCity;
				_personDetails.BirthDay = personDetail.BirthDay;
								
				_context.SaveChanges();
			}
			return _personDetails;
		}

		public void DeletePersonDetailById(int personDetailId)
		{
			var _personDetail = _context.PersonDetails.FirstOrDefault(n => n.Id == personDetailId);
			if (_personDetail != null)
			{
				_context.PersonDetails.Remove(_personDetail);
				_context.SaveChanges();
			}
		}
	}
}
