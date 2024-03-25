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
    public class IngredientRepository : IIngredientRepository
    {
        public void CreatIngredient(Ingredient a) => IngredientDAO.CreatIngredient(a);

        public Ingredient FindIngredientById(int id) => IngredientDAO.FindIngredientById(id);

        public List<Ingredient> GetIngredients(int educationId) => IngredientDAO.GetIngredients(educationId);

        public void UpdateIngredient(Ingredient a) => IngredientDAO.UpdateIngredient(a);
    }
}
