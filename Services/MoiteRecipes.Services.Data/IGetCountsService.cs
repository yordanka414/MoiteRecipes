namespace MoiteRecipes.Services.Data
{
    using MoiteRecipes.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        IndexViewModel GetCounts();
    }
}
