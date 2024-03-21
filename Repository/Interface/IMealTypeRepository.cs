using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IMealTypeRepository
    {
        List<MealType> GetMealTypes(int educationId);
        MealType FindMealTypeById(int id);
        void CreateMealType(MealType a);
        void UpdateMealType(MealType a);

    }
}
