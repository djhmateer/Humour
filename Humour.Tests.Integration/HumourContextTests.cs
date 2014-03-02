using FluentAssertions;
using Humour.Infrastructure;
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
                Title = "test2",
                Content = "content test"
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
                Content = randomString
            };

            context.Stories.Add(story);
            context.SaveChanges();

            var storyCheck = context.Stories.First(st => st.Content == randomString);
            storyCheck.Should().NotBeNull();
        }

        [TestMethod]
        public void ValidationErrorsThrowModelValidationException()
        {
            var uow = new EFUnitOfWorkFactory().Create();
            Action act = () =>
            {
                var repo = new StoryRepository();
                repo.Add(new Story());
                uow.Commit(true);
            };
            act.ShouldThrow<ModelValidationException>().WithMessage("The Title field is required", ComparisonMode.Substring);
            uow.Undo();
        }
    }
}
