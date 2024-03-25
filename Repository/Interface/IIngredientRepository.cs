using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetIngredients(int educationId);
        Ingredient FindIngredientById(int id);
        void CreatIngredient(Ingredient a);
        void UpdateIngredient(Ingredient a);
    }
}
