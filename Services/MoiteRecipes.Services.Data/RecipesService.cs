namespace MoiteRecipes.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MoiteRecipes.Data.Common.Repositories;
    using MoiteRecipes.Data.Models;
    using MoiteRecipes.Web.ViewModels.Recipes;

    public class RecipesService : IRecipesService
    {
        private readonly IDeletableEntityRepository<Recipe> recipeRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredietsRepository;

        public RecipesService(
            IDeletableEntityRepository<Recipe>
            recipeRepository,
            IDeletableEntityRepository<Ingredient> ingredietsRepository)
        {
            this.recipeRepository = recipeRepository;
            this.ingredietsRepository = ingredietsRepository;
        }

        public async Task CreateAsync(CreateRecipeInputModel input)
        {
            var recipe = new Recipe
            {
                CategoryId = input.CategoryId,
                CookingTime = TimeSpan.FromMinutes(input.CookingTime),
                PreparationTime = TimeSpan.FromMinutes(input.PreparationTime),
                Instructions = input.Instructions,
                Name = input.Name,
            };

            foreach (var inputIngredient in input.Ingredients)
            {
                var ingredient = this.ingredietsRepository.All().FirstOrDefault(x => x.Name == input.Name);
                if (ingredient == null)
                {
                    ingredient = new Ingredient { Name = inputIngredient.IngredientName };
                }

                recipe.Ingredients.Add(new RecipeIngredient
                {
                    Ingredient = ingredient,
                    Quantity = inputIngredient.Quantity,
                });
            }

            await this.recipeRepository.AddAsync(recipe);
            await this.recipeRepository.SaveChangesAsync();
        }
    }
}
