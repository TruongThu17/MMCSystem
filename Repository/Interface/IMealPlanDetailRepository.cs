using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IMealPlanDetailRepository
    {
        MealPlanDetail FindMealPlanDetailById(int MealPlanID, int DishId);
        void CreateMealPlanDetail(MealPlanDetail a);
        void UpdateMealPlanDetail(MealPlanDetail a);
        void DeleteMealPlanDetail(int MealPlanID);
        List<MealPlanDetail> GetMealPlanDetails(int MealPlanID);
    }
}
