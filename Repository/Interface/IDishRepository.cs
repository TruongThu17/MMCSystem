using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IDishRepository
    {
        List<Dish> GetDishs(int educationId, string? search);
        Dish FindDishById(int id);
        void CreateDish(Dish a);
        void UpdateDish(Dish a);
    }
}
