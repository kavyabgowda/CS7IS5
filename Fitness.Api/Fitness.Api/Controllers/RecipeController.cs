using Fitness.BusinessLogic;
using Fitness.DataObjects;
using System.Threading.Tasks;
using System.Web.Http;

namespace Fitness.Api.Controllers
{
    public class RecipeController : ApiController
    {
        public string Get()
        {
            RecipeBL recipeBL = new RecipeBL();
            var t = "test";
            return t;
        }
        public Task<Recipe> Get(int id)
        {
            RecipeBL recipeBL = new RecipeBL();
            return recipeBL.GetRecipeById(id);
        }
    }
}
            