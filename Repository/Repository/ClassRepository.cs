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
    public class ClassRepository : IClassRepository
    {
        public void CreateClass(Class a) => ClassDAO.CreateClass(a);

        public Class FindClassById(int id) => ClassDAO.FindClassById(id);

        public List<Class> GetClasses(int educationId)=> ClassDAO.GetClasses(educationId);

        public void UpdateClass(Class a) => ClassDAO.UpdateClass(a);
    }
}
