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
        public void TwoStoriesWithSameIdShouldBeTheSame()
        {
            var story1 = new Story { Id = 1, Title = "asdf" };
            var story2 = new Story { Id = 1, Title = "asdf" };
            (story1 == story2).Should().BeTrue();
        }

        [TestMethod]
        public void CanAddVoteToNewStory()
        {
            var story = new Story();
            story.Votes.Add(new Vote());
            story.Votes.Count.Should().Be(1);
        }

        [TestMethod]
        public void NewVoteShouldHaveDefaultStoryTypeOfJoke()
        {
            var story = new Story();
            story.StoryType.Should().Be(StoryType.Joke);
        }


    }
}
