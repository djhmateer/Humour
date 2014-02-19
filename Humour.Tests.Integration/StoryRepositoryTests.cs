using Humour.Respository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Humour.Tests.Integration
{
    [TestClass]
    public class StoryRepositoryTests
    {
        [TestMethod]
        public void CanInstantiateStoryRepository()
        {
            var storyRepository = new StoryRepository();
            Assert.IsNotNull(storyRepository);
        }
    }
}
