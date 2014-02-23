using Humour.Infrastructure;
using Humour.Model.Collections;
using System;
using System.ComponentModel.DataAnnotations;

namespace Humour.Model
{
    public class Story : DomainEntity<int>, IDateTracking
    {
        public Story()
        {
            Votes = new Votes();
            StoryType = StoryType.Joke;
            Rating = 0;
        }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        [Required]
        public string Title { get; set; }
        public StoryType StoryType { get; set; }
        public string Content { get; set; }
        public string VideoURL { get; set; }
        public string ImageURL { get; set; }
        public int Rating { get; set; }

        public Votes Votes { get; set; }

    }
}
