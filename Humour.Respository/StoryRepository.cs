using Humour.Model;
using Humour.Model.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Humour.Respository
{
    public class StoryRepository : Repository<Story>, IStoryRepository
    {
        public IEnumerable<Story> FindByTitle(string title)
        {
            return DataContextFactory.GetDataContext().Set<Story>()
                .Where(st => st.Title == title).ToList();
        }
    }
}
