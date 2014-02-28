using Humour.Model;
using System.ComponentModel.DataAnnotations;

namespace Humour.Mvc.Models.Story
{
    public class DisplayStory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public StoryType StoryType { get; set; }
        public string Content { get; set; }
        public string VideoURL { get; set; }
        public string ImageURL { get; set; }
        public int Rating { get; set; }
    }
}