using System.ComponentModel.DataAnnotations;

namespace UserRandomAPI.Models
{
    public class Uid
    {
        [Key]
        public int UidId { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}
