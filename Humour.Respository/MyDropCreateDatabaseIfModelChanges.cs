using Humour.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace Humour.Respository
{
    /// <summary>
    /// A custom implementation of HumourContext that creates a new Story and Vote.
    /// </summary>
    public class MyDropCreateDatabaseIfModelChanges : DropCreateDatabaseIfModelChanges<HumourContext>
    {
        /// <summary>
        /// Creates a new Story and Vote
        /// </summary>
        /// <param name="context">The context to which the new seed data is added.</param>
        protected override void Seed(HumourContext context)
        {
            var story1 = new Story { Id = 1, Title = "Banana", Content = "Q: Why did the banana go to the doctors? A: He wasn't peeling very well",Rating = 1, DateCreated=DateTime.Now.AddMinutes(-5) };
            var story2 = new Story { Id = 2, Title = "Stick", Content = "Q: What's brown and sticky? A: A stick", Rating = 2, DateCreated = DateTime.Now.AddMinutes(-3) };
            var story3 = new Story { Id = 3, Title = "Anarchist", Content = "Why do anarchists drink herbal tea? Because proper-tea is theft", Rating = 2 };
            ////story.Votes.Add(CreateVote());
            context.Stories.Add(story1);
            context.Stories.Add(story2);
            context.Stories.Add(story3);

            //if (!context.Users.Any(u => u.UserName == "dave"))
            //{
            //    var roleStore = new RoleStore<IdentityRole>(context);
            //    var roleManager = new RoleManager<IdentityRole>(roleStore);

            //    var userStore = new UserStore<IdentityUser>(context);
            //    var userManager = new UserManager<IdentityUser>(userStore);
            //    var user = new IdentityUser { UserName = "dave" };

            //    userManager.Create(user, "letmein");
            //    roleManager.Create(new IdentityRole { Name = "admin" });
            //    userManager.AddToRole(user.Id, "admin");
            //}
        }

        private static Vote CreateVote()
        {
            return new Vote { IPAddress = "192.168.1.1" };
        }
    }
}
