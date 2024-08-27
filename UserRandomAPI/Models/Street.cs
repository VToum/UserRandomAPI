using System.ComponentModel.DataAnnotations;

namespace UserRandomAPI.Models
{
    public class Street
    {
        [Key]
        public int StreetId { get; set; }
        public int number { get; set; }
        public string name { get; set; }
    }
}
