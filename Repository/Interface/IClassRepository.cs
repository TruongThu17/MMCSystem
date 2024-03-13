using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IClassRepository
    {
        List<Class> GetClasses(int educationId);
        Class FindClassById(int id);
        void CreateClass(Class a);
        void UpdateClass(Class a);
    }
}
