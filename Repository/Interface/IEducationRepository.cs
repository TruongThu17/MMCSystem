using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
	public interface IEducationRepository
	{
		List<Education> GetEducations();
		Education FindEducationById(int id);
		void CreateEducation(Education a);
		void UpdateEducation(Education a);
	}
}
