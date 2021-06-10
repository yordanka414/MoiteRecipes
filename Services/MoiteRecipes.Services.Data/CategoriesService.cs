namespace MoiteRecipes.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MoiteRecipes.Data.Common.Repositories;
    using MoiteRecipes.Data.Models;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.categoryRepository.AllAsNoTracking()
                 .Select(x => new
                 {
                     x.Id,
                     x.Name,
                 })
                 .OrderBy(x => x.Name)
                .ToList()
                 .Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
