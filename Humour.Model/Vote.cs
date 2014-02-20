using Humour.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Humour.Model
{
    public class Votes : DomainEntity<int>
    {
        [Required]
        public string IPAddress { get; set; }
        public DateTime DateAdded { get; set; }
        public Story Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
