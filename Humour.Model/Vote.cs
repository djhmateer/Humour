using Humour.Infrastructure;
using System;
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
    }
}
