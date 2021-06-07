namespace MoiteRecipes.Services.Data
{
    using System.Threading.Tasks;

    using MoiteRecipes.Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        Task CreateAsync(CreateRecipeInputModel input);
    }
}
