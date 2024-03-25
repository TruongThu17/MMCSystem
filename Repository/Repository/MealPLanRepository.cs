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
    public class MealPLanRepository : IMealPLanRepository
    {
        public void CreateMealPlan(MealPlan a) => MealPLanDAO.CreateMealPlan(a);

        public MealPlan FindMealPlanById(int id) => MealPLanDAO.FindMealPlanById(id);

        public List<MealPlan> GetMealPlans(int educationId) => MealPLanDAO.GetMealPlans(educationId);

        public void UpdateMealPlan(MealPlan a) => MealPLanDAO.UpdateMealPlan(a);
    }
}
