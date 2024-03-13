using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IClassTypeRepository
    {
        List<ClassType> GetClassTypes();
        ClassType FindClassTypeById(int id);
        void CreateClassType(ClassType a);
        void UpdateClassType(ClassType a);
    }
}
