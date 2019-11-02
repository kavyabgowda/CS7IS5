using Fitness.DataObjects;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fitness.DataAccess
{
    public class RecipeDA
    {
        private readonly HttpClient _spoonacular = new HttpClient
        {
            BaseAddress = new Uri("https://api.spoonacular.com"),
        };

        public async Task<Recipe> GetRecipeByIdAsync(int id)
        {
            var response = await _spoonacular.GetAsync($"/recipes/{id}/information?apiKey=fe4526dd8d634223b5d76b084df3a1f3");
            var recipe = await response.Content.ReadAsAsync<Recipe>();
            recipe.recipeId = id;
            return recipe;
        }
    }
}
