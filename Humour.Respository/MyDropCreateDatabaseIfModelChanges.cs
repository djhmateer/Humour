using Humour.Model;
using System.Data.Entity;

namespace Humour.Respository
{
    /// <summary>
    /// A custom implementation of HumourContext that creates a new Story and Vote.
    /// </summary>
    public class MyDropCreateDatabaseIfModelChanges : DropCreateDatabaseIfModelChanges<HumourContext>
    {
        /// <summary>
        /// Creates a new Story and Vote
        /// </summary>
        /// <param name="context">The context to which the new seed data is added.</param>
        protected override void Seed(HumourContext context)
        {
            var story1 = new Story { Id = 1, Title = "Banana", Content = "Q: Why did the banana go to the doctors? A: He wasn't peeling very well",Rating = 1 };
            ////story.Votes.Add(CreateVote());
            context.Stories.Add(story1);
        }

        private static Vote CreateVote()
        {
            return new Vote { IPAddress = "192.168.1.1" };
        }
    }
}
