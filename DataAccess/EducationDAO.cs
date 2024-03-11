using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class EducationDAO
	{
		public static List<Education> GetEducations()
		{
			var listEducations = new List<Education>();
			try
			{
				using (var context = new MMCDbContext())
				{
					listEducations = context.Educations.ToList();
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
			return listEducations;
		}
		public static Education FindEducationById(int id)
		{
			Education p = new Education();
			try
			{
				using (var context = new MMCDbContext())
				{
					p = context.Educations.SingleOrDefault(x => x.Id == id);
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
			return p;
		}

		public static void CreateEducation(Education a)
		{
			try
			{
				using (var context = new MMCDbContext())
				{
					context.Educations.Add(a);
					context.SaveChanges();
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
		}
		public static void UpdateEducation(Education a)
		{

			try
			{
				using (var context = new MMCDbContext())
				{
					context.Entry<Education>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
					context.SaveChanges();
				}
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
		}
	}
}
