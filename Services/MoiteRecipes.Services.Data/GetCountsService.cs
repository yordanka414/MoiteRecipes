using MoiteRecipes.Data.Common.Repositories;
using MoiteRecipes.Data.Models;
using MoiteRecipes.Web.ViewModels.Home;
using System.Linq;

namespace MoiteRecipes.Services.Data
{
    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IRepository<Image> imagesRepository;
        private readonly IDeletableEntityRepository<Recipe> recipeRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRepository;

        public GetCountsService(
            IDeletableEntityRepository<Category> categoryRepository,
            IRepository<Image> imagesRepository,
            IDeletableEntityRepository<Recipe> recipeRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRepository
            )
        {
            this.categoryRepository = categoryRepository;
            this.imagesRepository = imagesRepository;
            this.recipeRepository = recipeRepository;
            this.ingredientsRepository = ingredientsRepository;
        }

        public IndexViewModel GetCounts()
        {
            return new IndexViewModel
            {
                RecipesCount = this.recipeRepository.All().Count(),
                CategoriesCount = this.categoryRepository.AllAsNoTracking().Count(),
                IngredientsCount = this.ingredientsRepository.AllAsNoTracking().Count(),
                ImagesCount = this.imagesRepository.AllAsNoTracking().Count(),
            };
        }
    }
}
