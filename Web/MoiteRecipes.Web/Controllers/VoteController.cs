namespace MoiteRecipes.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MoiteRecipes.Services.Data;
    using MoiteRecipes.Web.ViewModels.Votes;

    [ApiController]
    [Route("api/[controller]")]
    public class VoteController : Controller
    {
        private readonly IVotesService votesService;

        public VoteController(IVotesService votesService)
        {
            this.votesService = votesService;
        }

        [HttpPost]
        [Authorize]
       
        public async Task<ActionResult<PostVoteResponseViewModel>> Post(PostVoteInputViewModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.votesService.SetVoteAsync(input.RecipeId, userId, input.Value);
            ////return average
            var averageVote = this.votesService.GetAverageVote(input.RecipeId);
            return new PostVoteResponseViewModel {AverageVote =averageVote };
        }
    }
}
