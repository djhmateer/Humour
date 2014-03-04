using FluentAssertions;
using Humour.Mvc.Controllers;
using Humour.Mvc.Models;
using Humour.Mvc.Models.Story;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Web.Mvc;

namespace Humour.Tests.Mvc
{
    [TestClass]
    public class StoryControllerTests
    {
        [TestMethod]
        public void Index_GivenDefault_ShouldReturnVMSortedByTitle()
        {
            var controller = new StoryController(new FakeStoryRepository(), null);
            var result = controller.Index(1, "Title", "ASC") as ViewResult;
            var model = ((PagerModel<DisplayStory>)result.Model);
            
            Assert.AreEqual(22, model.Data.Count());
            model.Data.Count().Should().Be(22);

            model.Data.First().Title.Should().Be("1 the first title");
        }
    }
}
