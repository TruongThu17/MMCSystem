using Data.Models;
using DataAccess;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
	public class EducationRepository : IEducationRepository
	{
		public void CreateEducation(Education a) => EducationDAO.CreateEducation(a);

		public Education FindEducationById(int id) => EducationDAO.FindEducationById(id);

		public List<Education> GetEducations() => EducationDAO.GetEducations();

		public void UpdateEducation(Education a) => EducationDAO.UpdateEducation(a);
	}
}
