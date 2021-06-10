namespace MoiteRecipes.Web.ViewModels
{
    using System;

    public class PagingViewModel
    {
        public int PageNumber { get; set; }

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCoutnt;

        public int PagesCoutnt => (int)Math.Ceiling((double)this.RecipesCount / this.ItemsPerPage);

        public int RecipesCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
