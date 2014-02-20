using Humour.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Humour.Model
{
    public class Story : DomainEntity<int>
    {
        [Required]
        public string Title { get; set; }
        public StoryType StoryType { get; set; }
        public string Content { get; set; }
        public string VideoURL { get; set; }
        public string ImageURL { get; set; }
        public DateTime AddedDate { get; set; }
        public int Rating { get; set; }

        public Votes Votes { get; set; }
    }
}
