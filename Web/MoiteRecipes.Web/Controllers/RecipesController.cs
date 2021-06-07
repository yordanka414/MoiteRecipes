namespace MoiteRecipes.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MoiteRecipes.Services.Data;
    using MoiteRecipes.Web.ViewModels.Recipes;
    using System.Threading.Tasks;

    public class RecipesController : Controller
    {
        private readonly IRecipesService recipesService;
        private readonly ICategoriesService categoriesService;

        public RecipesController(IRecipesService recipesService, ICategoriesService categoriesService)
        {
            this.recipesService = recipesService;
            this.categoriesService = categoriesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateRecipeInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRecipeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }
            await this.recipesService.CreateAsync(input);
            return this.Redirect("/");
        }
    }
}
