using Humour.Model;
using Humour.Respository.Configuration;
using System.Data.Entity;

namespace Humour.Respository
{
    public class HumourContext : DbContext
    {
        public HumourContext() : base("Humour") { }
        public DbSet<Story> Stories { get; set; }

        /// <summary>
        /// Configures the EF context.
        /// </summary>
        /// <param name="modelBuilder">The model builder that needs to be configured.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StoryConfiguration());
        }
    }
}
