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
    public class MealPlanDetailRepository : IMealPlanDetailRepository
    {
        public void CreateMealPlanDetail(MealPlanDetail a) => MealPlanDetailDAO.CreateMealPlanDetail(a);

        public void DeleteMealPlanDetail(int MealPlanID) => MealPlanDetailDAO.DeleteMealPlanDetail(MealPlanID);

        public MealPlanDetail FindMealPlanDetailById(int MealPlanID, int DishId) => MealPlanDetailDAO.FindMealPlanDetailById(MealPlanID, DishId);

        public List<MealPlanDetail> GetMealPlanDetails(int MealPlanID) => MealPlanDetailDAO.GetMealPlanDetails(MealPlanID);

        public void UpdateMealPlanDetail(MealPlanDetail a) => MealPlanDetailDAO.UpdateMealPlanDetail(a);
    }
}
