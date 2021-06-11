namespace MoiteRecipes.Web.ViewModels.Votes
{
    using System.ComponentModel.DataAnnotations;

    public class PostVoteInputViewModel
    {
        public int RecipeId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}
