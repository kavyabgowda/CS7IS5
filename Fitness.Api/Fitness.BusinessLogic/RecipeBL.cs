using Fitness.DataAccess;
using Fitness.DataObjects;
using System.Threading.Tasks;

namespace Fitness.BusinessLogic
{
    public class RecipeBL
    {
        RecipeDA recipeDA = null;
        public RecipeBL()
        {
            recipeDA = new RecipeDA();
        }
        public Task<Recipe> GetRecipeById(int id)
        {
            return recipeDA.GetRecipeByIdAsync(id);
        }
    }
}
