using System.ComponentModel.DataAnnotations;
using System.IO;
using UserRandomAPI.Models;

namespace UserRandomAPI.Entity
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
    }
}