using FluentAssertions;
using Humour.Model;
using Humour.Respository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Humour.Tests.Integration
{
    [TestClass]
    public class HumourContextTests : IntegrationTestBase
    {
        [TestMethod]
        public void CanAddStoryUsingContext()
        {
            var story = new Story
            {
                Title = "test",
                Content = "content test"
                //DateCreated = DateTime.Now,
                //DateModified = DateTime.Now
            };

            var context = new HumourContext();
            context.Stories.Add(story);
            context.SaveChanges();
        }

        [TestMethod]
        public void CanExecuteQueryAgainstDataContext()
        {
            string randomString = Guid.NewGuid().ToString().Substring(0, 25);
            var context = DataContextFactory.GetDataContext();
            var story = new Story
            {
                Title = "test",
                Content = randomString,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            context.Stories.Add(story);
            context.SaveChanges();

            var storyCheck = context.Stories.First(st => st.Content == randomString);
            storyCheck.Should().NotBeNull();
        }
    }
}
