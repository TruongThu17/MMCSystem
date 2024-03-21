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
    public class MealTypeRepository : IMealTypeRepository
    {
        public void CreateMealType(MealType a) => MealTypeDAO.CreateMealType(a);

        public MealType FindMealTypeById(int id) => MealTypeDAO.FindMealTypeById(id);

        public List<MealType> GetMealTypes(int educationId) => MealTypeDAO.GetMealTypes(educationId);

        public void UpdateMealType(MealType a) => MealTypeDAO.UpdateMealType(a);
    }
}
