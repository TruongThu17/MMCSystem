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
    public class ClassTypeRepository : IClassTypeRepository
    {
        public void CreateClassType(ClassType a) => ClassTypeDAO.CreateClassType(a);

        public ClassType FindClassTypeById(int id) => ClassTypeDAO.FindClassTypeById(id);

        public List<ClassType> GetClassTypes() => ClassTypeDAO.GetClassTypes();

        public void UpdateClassType(ClassType a) => ClassTypeDAO.UpdateClassType(a);
    }
}
