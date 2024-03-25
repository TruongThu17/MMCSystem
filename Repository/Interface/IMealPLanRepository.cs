using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IMealPLanRepository
    {
        List<MealPlan> GetMealPlans(int educationId);
        MealPlan FindMealPlanById(int id);
        void CreateMealPlan(MealPlan a);
        void UpdateMealPlan(MealPlan a);
    }
}
