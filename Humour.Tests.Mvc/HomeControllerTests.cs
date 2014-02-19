using Humour.Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace Humour.Tests.Mvc
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexHasNoModel()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual(null, result.Model);
        }
    }
}
