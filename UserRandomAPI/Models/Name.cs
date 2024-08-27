using System.ComponentModel.DataAnnotations;

namespace UserRandomAPI.Entity
{
    public class Name
    {
        [Key]
        public int NameId { get; set; }
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }
}