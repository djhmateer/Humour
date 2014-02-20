using Humour.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Humour.Tests.Unit
{
    [TestClass]
    public class StoryTests
    {
        [TestMethod]
        public void NewStoryShouldHaveEmptyId()
        {
            var story = new Story();
            //Assert.AreEqual(0, story.Id);
            //story.Id.Should().Be(0);
            story.IsTransient().Should().BeTrue();
        }

        [TestMethod]
        public void NewStoryShouldHaveEmptyId2()
        {
            var story = new Story();
            //story.Votes **HERE**
        }

    }
}
