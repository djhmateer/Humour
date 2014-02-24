using Humour.Model;
using System.Data.Entity.ModelConfiguration;

namespace Humour.Respository.Configuration
{
    /// <summary>
    /// Configures the behavior for a person in the model and the database.
    /// </summary>
    public class StoryConfiguration : EntityTypeConfiguration<Story>
    {
        /// <summary>
        /// Initializes a new instance of the PersonConfiguration class.
        /// </summary>
        public StoryConfiguration()
        {
            Property(x => x.Title).IsRequired().HasMaxLength(25);
            Property(x => x.Content).IsRequired().HasMaxLength(2048);
        }
    }
}
