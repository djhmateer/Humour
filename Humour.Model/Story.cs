using Humour.Infrastructure;
using Humour.Model.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Humour.Model
{
    public class Story : DomainEntity<int>, IDateTracking
    {
        public Story()
        {
            Votes = new Votes();
            StoryType = StoryType.None;
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

        /// <summary>
        /// Validates this object. It validates dependencies between properties and also calls Validate on child collections;
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
            if (StoryType == StoryType.None)
            {
                yield return new ValidationResult("StoryType can't be None.", new[] { "StoryType" });
            }

            //if (DateOfBirth < DateTime.Now.AddYears(Constants.MaxAgePerson * -1))
            //{
            //    yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            //}
            //if (DateOfBirth > DateTime.Now)
            //{
            //    yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            //}

            foreach (var result in Votes.Validate())
            {
                yield return result;
            }

            //foreach (var result in EmailAddresses.Validate())
            //{
            //    yield return result;

            //}
            //foreach (var result in HomeAddress.Validate())
            //{
            //    yield return result;
            //}

            //foreach (var result in WorkAddress.Validate())
            //{
            //    yield return result;
            //}
        }

    }
}
