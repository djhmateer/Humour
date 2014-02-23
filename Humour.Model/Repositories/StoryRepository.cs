using Humour.Infrastructure;
using System.Collections.Generic;

namespace Humour.Model.Repositories
{
    /// <summary>
    /// Defines the various methods available to work with people in the system.
    /// </summary>
    public interface IStoryRepository : IRepository<Story, int>
    {
        /// <summary>
        /// Gets a list of all the stories title exactly matches.
        /// </summary>
        /// <param name="lastName">The last name that the system should search for.</param>
        /// <returns>An IEnumerable of Story with the matching people.</returns>
        IEnumerable<Story> FindByTitle(string title);
    }
}
