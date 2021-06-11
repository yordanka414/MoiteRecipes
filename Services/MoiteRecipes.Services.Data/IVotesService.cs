namespace MoiteRecipes.Services.Data
{
    using System.Threading.Tasks;

    public interface IVotesService
    {
        Task SetVoteAsync(int recipId, string userId, byte value);

        double GetAverageVote(int recipeId);
    }
}
