using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Humour.Mvc.Models.Story
{
    public class CreateAndEditStory : IValidatableObject
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        //public StoryType StoryType { get; set; }
        public string Content { get; set; }
        public string VideoURL { get; set; }
        public string ImageURL { get; set; }
        public int Rating { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Content))
            {
                yield return new ValidationResult("Please enter some content.", new[] { "Content" });
            }
        }
    }
}