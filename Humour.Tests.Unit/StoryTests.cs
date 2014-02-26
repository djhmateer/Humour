using Humour.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;

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
        public void NewVoteShouldHaveDefaultStoryTypeOfNone()
        {
            var story = new Story();
            story.StoryType.Should().Be(StoryType.None);
        }

        [TestMethod]
        public void TitleIsRequired()
        {
            var story = new Story();
            var validationResults = story.Validate();
            validationResults.Count(x => x.MemberNames.Contains("Title")).Should().BeGreaterThan(0);
        }

        // Why is Story not being validated with Object level validation here?
        //[TestMethod]
        //public void StoryWithTypeStoryTypeNoneIsInvalid()
        //{
        //    var story = new Story();
        //    story.Title = "asdf";
        //    story.StoryType = StoryType.None;
        //    story.Validate().Count(x => x.MemberNames.Contains("StoryType")).Should().BeGreaterThan(0);
        //}
    }
}
