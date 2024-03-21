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
    public class DishRepository : IDishRepository
    {
        public void CreateDish(Dish a) => DishDAO.CreateDish(a);

        public Dish FindDishById(int id) => DishDAO.FindDishById(id);

        public List<Dish> GetDishs(int educationId, string? search) => DishDAO.GetDishs(educationId,search);

        public void UpdateDish(Dish a) => DishDAO.UpdateDish(a);
    }
}
