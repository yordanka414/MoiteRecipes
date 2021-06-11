namespace MoiteRecipes.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using MoiteRecipes.Data.Common.Repositories;
    using MoiteRecipes.Data.Models;

    public class VoteService : IVotesService
    {
        private readonly IRepository<Vote> voteRepository;

        public VoteService(IRepository<Vote> voteRepository)
        {
            this.voteRepository = voteRepository;
        }

        public double GetAverageVote(int recipeId)
        {
            var averageCount = this.voteRepository
                .All()
                .Where(x => x.RecipeId == recipeId)
                .Average(x => x.Value);

            return averageCount;
        }

        public async Task SetVoteAsync(int recipId, string userId, byte value)
        {
            var vote = this.voteRepository.All().FirstOrDefault(v => v.RecipeId == recipId && v.UserId == userId);
            if (vote == null)
            {
                vote = new Vote
                {
                    RecipeId = recipId,
                    UserId = userId,
                };

                await this.voteRepository.AddAsync(vote);
            }

            vote.Value = value;

            await this.voteRepository.SaveChangesAsync();
        }
    }
}
