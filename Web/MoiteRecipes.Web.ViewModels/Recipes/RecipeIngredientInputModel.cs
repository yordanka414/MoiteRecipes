namespace MoiteRecipes.Web.ViewModels.Recipes
{
    using System.ComponentModel.DataAnnotations;

    using MoiteRecipes.Data.Models;

    using MoiteRecipes.Services.Mapping;

    public class RecipeIngredientInputModel : IMapFrom<RecipeIngredient>
    {
        [Required]
        [MinLength(3)]
        public string IngredientName { get; set; }

        [Required]
        [MinLength(3)]
        public string Quantity { get; set; }
    }
}
