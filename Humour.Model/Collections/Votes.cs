using System.Collections.Generic;

namespace Humour.Model.Collections
{
    /// <summary>
    /// Represents a collection of Vote instances in the system.
    /// </summary>
    public class Votes : CollectionBase<Vote>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Votes"/> class.
        /// </summary>
        public Votes() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Votes"/> class.
        /// </summary>
        /// <param name="initialList">Accepts an IList of Votes as the initial list.</param>
        public Votes(IList<Vote> initialList) : base(initialList) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Votes"/> class.
        /// </summary>
        /// <param name="initialList">Accepts a CollectionBase of Vote as the initial list.</param>
        public Votes(CollectionBase<Vote> initialList) : base(initialList) { }

        /// <summary>
        /// Adds a new instance of Vote to the collection.
        /// </summary>
        /// <param name="ipAddress">The ip address</param>
        public void Add(string ipAddress)
        {
            Add(new Vote { IPAddress = ipAddress });
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
