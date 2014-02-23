using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humour.Model.Collections
{
        /// <summary>
        /// Represents a collection of Vote instances in the system.
        /// </summary>
        public class Stories : CollectionBase<Story>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Stories"/> class.
            /// </summary>
            public Stories() { }

            /// <summary>
            /// Initializes a new instance of the <see cref="Stories"/> class.
            /// </summary>
            /// <param name="initialList">Accepts an IList of Stories as the initial list.</param>
            public Stories(IList<Story> initialList) : base(initialList) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="Stories"/> class.
            /// </summary>
            /// <param name="initialList">Accepts a CollectionBase of Story as the initial list.</param>
            public Stories(CollectionBase<Story> initialList) : base(initialList) { }

            /// <summary>
            /// Adds a new instance of Story to the collection.
            /// </summary>
            /// <param name="ipAddress">The title</param>
            public void Add(string title)
            {
                Add(new Story { Title = title });
            }

            /// <summary>
            /// Validates the current collection by validating each individual item in the collection.
            /// </summary>
            /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
            //public IEnumerable<ValidationResult> Validate()
            //{
            //    var errors = new List<ValidationResult>();
            //    foreach (var address in this)
            //    {
            //        errors.AddRange(address.Validate());
            //    }
            //    return errors;
            //}
        }
    }
