namespace MoiteRecipes.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AutoMapper;

    using MoiteRecipes.Data.Models;
    using MoiteRecipes.Services.Mapping;

    public class SignalRecipeViewModel : IMapFrom<Recipe>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AddedByUserUserName { get; set; }

        public string ImageUrl { get; set; }

        public string Instructions { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionsCount { get; set; }

        public int CategoryRecipesCount { get; set; }

        public ICollection<RecipeIngredientInputModel> Ingredients { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Recipe, SignalRecipeViewModel>()
               .ForMember(x => x.ImageUrl, opt =>
                   opt.MapFrom(x =>
                       x.Images.FirstOrDefault().RemoteImageUrl != null ?
                       x.Images.FirstOrDefault().RemoteImageUrl :
                       "/images/recipes/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}
