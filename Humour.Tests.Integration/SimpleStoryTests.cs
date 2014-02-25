using Humour.Respository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humour.Tests.Integration
{
    [TestClass]
    public class SimpleStoryTests : IntegrationTestBase
    {
        [TestMethod]
        public void CanGetBasicPerson()
        {
            //Person person = CreatePerson();
            //StoryRepository repository = new StoryRepository();
            //using (IUnitOfWork unitOfWork = new EFUnitOfWorkFactory().Create())
            //{
            //    repository.Add(person);
            //}
            //PeopleRepository repositoryConfirm = new PeopleRepository();
            //Person personConfirm = repositoryConfirm.FindById(person.Id);
            //personConfirm.Id.Should().Be(person.Id);

            //var friendsWithATattoo = repository.FindAll(
            //      x => x.FirstName == "Goo" && x.Type == PersonType.Friend);

        }

    }
}
