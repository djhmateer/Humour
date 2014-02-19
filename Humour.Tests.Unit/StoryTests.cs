using Humour.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Humour.Tests.Unit
{
    [TestClass]
    public class StoryTests
    {
        [TestMethod]
        public void NewStoryShouldHaveEmptyId()
        {
            var story = new Story();
            Assert.AreEqual(0, story.Id);
        }
    }
}
