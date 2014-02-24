using Humour.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Humour.Model
{
    public class Vote : DomainEntity<int>, IHasOwner
    {
        [Required]
        public string IPAddress { get; set; }
        public DateTime DateAdded { get; set; }
        public Story Owner { get; set; }
        public int OwnerId { get; set; }

        /// <summary>
        /// Validates this object. It validates dependencies between properties and also calls Validate on child collections;
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
            //if (Type == PersonType.None)
            //{
            //    yield return new ValidationResult("Type can't be None.", new[] { "Type" });
            //}

            //if (DateOfBirth < DateTime.Now.AddYears(Constants.MaxAgePerson * -1))
            //{
            //    yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            //}
            //if (DateOfBirth > DateTime.Now)
            //{
            //    yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            //}

            //foreach (var result in PhoneNumbers.Validate())
            //{
            //    yield return result;
            //}

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
