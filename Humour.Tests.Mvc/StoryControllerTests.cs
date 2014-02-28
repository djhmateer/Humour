using FluentAssertions;
using Humour.Model;
using Humour.Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Humour.Tests.Mvc
{
    [TestClass]
    public class StoryControllerTests
    {
        [TestMethod]
        public void IndexSortsCorrectly()
        {
            var controller = new StoryController(new FakeStoryRepository(), null);
            var result = controller.Index(1, "DateOfBirth", "DESC") as ViewResult;
            var model = ((IEnumerable<Story>)result.Model).ToList();
            model.Count().Should().Be(22);
            model.First().Title.Should().Be("1 the first title");
        }
    }
}
