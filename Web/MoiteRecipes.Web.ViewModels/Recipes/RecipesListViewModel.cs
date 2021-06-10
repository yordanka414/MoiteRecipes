namespace MoiteRecipes.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using MoiteRecipes.Data.Models;
    using MoiteRecipes.Services.Mapping;

    public class RecipesListViewModel : PagingViewModel
    {
        public IEnumerable<RecipeInListViewModel> Recipes { get; set; }
    }
}
